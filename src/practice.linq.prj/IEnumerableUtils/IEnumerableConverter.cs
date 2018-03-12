using System;
using System.Collections.Generic;

namespace Practice.Linq.IEnumerableUtils
{
	/// <summary>
	/// Interface that allows manipulate with generic
	/// collection to solve our task.
	/// </summary>
	/// <typeparam name="TItem">Type of collection item.</typeparam>
	/// <typeparam name="TAggregate">Type of aggregated value.</typeparam>
	public interface IEnumerableConverter<TItem, out TAggregate>
	{
		/// <summary>
		/// Generate collection that will store <paramref name="count"/>
		/// random generated values.
		/// </summary>
		/// <param name="count">Count of element.</param>
		/// <param name="max">Maximum random value.</param>
		/// <returns>Collection with random values.</returns>
		IEnumerable<TItem> Generate(
			int count,
			TItem max);

		/// <summary>
		/// Do necessary operation with collection
		/// to solve our task.
		/// </summary>
		/// <param name="source">Input collection.</param>
		/// <returns>Processed collection.</returns>
		IEnumerable<TItem> Process(
			IEnumerable<TItem> source);


		/// <summary>
		/// Calculate sum of elements in collection.
		/// </summary>
		/// <param name="source">Input collection.</param>
		/// <returns>Sum of elements in collection.</returns>
		TAggregate Sum(
			IEnumerable<TItem> source);

		/// <summary>
		/// Calculate multiplication of elements in collection.
		/// </summary>
		/// <param name="source">Input collection.</param>
		/// <returns>Multiplication of elements in collection.</returns>
		TAggregate Multiply(
			IEnumerable<TItem> source);
	}
}