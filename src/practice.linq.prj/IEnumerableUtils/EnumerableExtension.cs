using System;
using System.Collections.Generic;

using Practice.Linq.Utils;

namespace Practice.Linq.IEnumerableUtils
{
	/// <summary>
	/// Static class that provide extension function 
	/// that allows to work with generic collection
	/// in functional style.
	/// </summary>
	public static class EnumerableExtension
	{
		/// <summary>
		/// Returns a generated collection 
		/// of <paramref name="count"/> elements.
		/// For generation using function provided in
		/// <paramref name="generator"/> argument.
		/// </summary>
		/// <typeparam name="T">Type of generated items.</typeparam>
		/// <param name="count">Count of generated items.</param>
		/// <param name="generator">
		/// Function that specified how generate items for collection.
		/// </param>
		/// <returns>Generated collection.</returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Throws if made request to generate negate count or zero elements.
		/// </exception>
		/// <exception cref="NullReferenceException">
		/// Throws if generated function was null.
		/// </exception>
		public static IEnumerable<T> Generate<T>(
			int count,
			Func<uint, T> generator)
		{
			Assert.ThrowIfLessOrEqualsZero(
				count,
				() => new ArgumentOutOfRangeException(
					nameof(count),
					"Count of generated element should be " +
					"greater that zero"));
			Assert.ThrowIfNull(
				generator,
				nameof(generator));

			for (uint i = 0; i < count; i++)
				yield return generator(i);
		}

		/// <summary>
		/// Returns specified <paramref name="count"/> of elements in collection 
		/// started in specified place in it.
		/// </summary>
		/// <typeparam name="T">Type of elements.</typeparam>
		/// <param name="source">Source collection.</param>
		/// <param name="start">
		/// The number of elements to skip before returning elements.
		/// </param>
		/// <param name="count">
		/// Count of returning elements.
		/// </param>
		/// <returns>
		/// Collection that have elements in specified range 
		/// in original collection.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Throws if specified incorrect range of returning elements.
		/// </exception>
		/// <exception cref="NullReferenceException">
		/// Throws if source collection was null.
		/// </exception>
		public static IEnumerable<T> TakeStart<T>(
			this IEnumerable<T> source,
			int start,
			int count)
		{
			Assert.ThrowIfNull(
				source,
				nameof(source));
			Assert.ThrowIfLessOrEqualsZero(
				count,
				() => new ArgumentOutOfRangeException(
					nameof(count),
					"Count of selected element should be " +
					"greater that zero"));
			Assert.ThrowIfLessZero(
				count,
				() => new ArgumentOutOfRangeException(
					nameof(start),
					"Start index should be " +
					"greater that or equals zero"));

			var sizeExceptionFunc =
				new Func<ArgumentOutOfRangeException>(()
					=> new ArgumentOutOfRangeException(
						nameof(source),
						"Collection don't have enough elements"));

			if (source is ICollection<T> list)
				Assert.ThrowIf(
					() => list.Count < start + count,
					sizeExceptionFunc);


			using (var enumerator = source.GetEnumerator())
			{
				for (var i = 0; i <= start; i++)
					if (!enumerator.MoveNext())
						throw sizeExceptionFunc();

				for (var i = 0; i < count; i++)
				{
					yield return enumerator.Current;
					if (!enumerator.MoveNext() && i != count - 1)
						throw sizeExceptionFunc();
				}
					
			}
		}

		/// <summary>
		/// Returns collection that contains elements
		/// satisfied given condition.
		/// </summary>
		/// <typeparam name="T">Type of elements in collection.</typeparam>
		/// <param name="source">Source collection.</param>
		/// <param name="filterFunction">
		/// Function that determinate should given element pushed in 
		/// output collection or not. 
		/// </param>
		/// <returns>
		/// Collection that contains elements
		/// satisfied given condition.
		/// </returns>
		/// <exception cref="NullReferenceException">
		/// Throws if source collection or function was null.
		/// </exception>
		public static IEnumerable<T> For<T>(
			this IEnumerable<T> source,
			Predicate<T> filterFunction)
		{
			Assert.ThrowIfNull(
				source,
				nameof(source));

			Assert.ThrowIfNull(
				filterFunction,
				nameof(filterFunction));

			foreach (var item in source)
				if (filterFunction(item))
					yield return item;
		}

		/// <summary>
		/// Copy collection in list.
		/// </summary>
		/// <typeparam name="T">Type of elements in collection.</typeparam>
		/// <param name="source">Source collection.</param>
		/// <returns>
		/// List that contains elements that was in source collection.
		/// </returns>
		/// <exception cref="NullReferenceException">
		/// Throws if source collection was null.
		/// </exception>
		public static IList<T> CopyToList<T>(
			this IEnumerable<T> source)
		{
			Assert.ThrowIfNull(
				source,
				nameof(source));

			var retList = source is ICollection<T> list 
				? new List<T>(list.Count)
				: new List<T>();
			foreach (var item in source)
				retList.Add(item);
			return retList;
		}

		/// <summary>
		/// Returns a sorted collection by specified field.
		/// </summary>
		/// <typeparam name="TItem">Type of elements in collection.</typeparam>
		/// <typeparam name="TField">Type of fieid that will using for sorting.</typeparam>
		/// <param name="source">Source collection.</param>
		/// <param name="fieldSelector">Function that select field from object 
		/// that will using for sorting.
		/// </param>
		/// <returns>A sorted collection by specified field.</returns>
		/// <exception cref="NullReferenceException">
		/// Throws if source collection or function was null.
		/// </exception>
		public static IEnumerable<TItem> Sort<TItem, TField>(
			this IEnumerable<TItem> source,
			Func<TItem, TField> fieldSelector)
				where TField : IComparable<TField>
		{
			Assert.ThrowIfNull(
				source,
				nameof(source));
			Assert.ThrowIfNull(
				fieldSelector,
				nameof(fieldSelector));

			int[] gaps =
			{
				1, 4, 9, 20, 46, 103, 233, 525, 1182, 2660,
				5985, 13467, 30301, 68178, 153401, 345152, 776591
			};

			var gapIndex = gaps.Length - 1;
			var array = source.CopyToList();
			if (array.Count == 0)
				return array;

			while (gaps[gapIndex] > array.Count)
				gapIndex--;

			while (gapIndex >= 0)
			{
				var gap = gaps[gapIndex];
				for (int i = gap; i < array.Count; i++)
				{
					var temp = array[i];
					int j;
					for (j = i;
						j >= gap
							&& fieldSelector(
								array[j - gap])
								.CompareTo(
									fieldSelector(temp)) > 0;
							j -= gap)
						array[j] = array[j - gap];
					array[j] = temp;
				}
				gapIndex--;
			}
			return array;
		}

		/// <summary>
		/// Apply aggregation function for source collection.
		/// </summary>
		/// <typeparam name="TItem">Type of elements in collection.</typeparam>
		/// <typeparam name="TSeed">Type of accumulated value.</typeparam>
		/// <param name="source">Source collection.</param>
		/// <param name="accumulateFunc">Aggregation function.</param>
		/// <param name="seed">Initial value for aggregation function.</param>
		/// <returns>
		/// Got aggregated value.
		/// </returns>
		/// <exception cref="NullReferenceException">
		/// Throws if source collection or function was null.
		/// </exception>
		public static TSeed Accumulate<TItem, TSeed>(
			this IEnumerable<TItem> source,
			Func<TSeed, TItem, TSeed> accumulateFunc,
			TSeed seed = default(TSeed))
		{
			Assert.ThrowIfNull(
				source,
				nameof(source));
			Assert.ThrowIfNull(
				accumulateFunc,
				nameof(accumulateFunc));

			foreach (var item in source)
				seed = accumulateFunc(seed, item);
			return seed;
		}
	}
}