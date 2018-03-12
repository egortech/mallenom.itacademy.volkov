using System;
using System.Collections.Generic;
using System.Numerics;

namespace Practice.Linq.IEnumerableUtils
{
	/// <inheritdoc />
	/// <summary>
	/// Provide the class that allows us to solve the task
	/// using own LINQ-like methods.
	/// </summary>
	public class OwnEnumerableConverter
		: IEnumerableConverter<int, BigInteger>
	{
		/// <inheritdoc />
		/// <summary>
		/// Generate collection that will store <paramref name="count" />
		/// random generated values.
		/// </summary>
		/// <param name="count">Count of element.</param>
		/// <param name="max">Maximum random value.</param>
		/// <returns>Collection with random values.</returns>
		public IEnumerable<int> Generate(
			int count,
			int max)
		{
			var rand = new Random();
			return EnumerableExtension.Generate(
				count,
				i => rand.Next(1, max));
		}

		/// <inheritdoc />
		/// <summary>
		/// Do necessary operation with collection
		/// to solve our task.
		/// </summary>
		/// <param name="source">Input collection.</param>
		/// <returns>Processed collection.</returns>
		public IEnumerable<int> Process(
			IEnumerable<int> source)
			=> source.TakeStart(5, 20)
				.For(i => i > 10 & i < 100)
				.Sort(i => i);

		/// <inheritdoc />
		/// <summary>
		/// Calculate sum of elements in collection.
		/// </summary>
		/// <param name="source">Input collection.</param>
		/// <returns>Sum of elements in collection.</returns>
		public BigInteger Sum(
			IEnumerable<int> source)
			=> source.Accumulate(
				(accumulator, value)
					=> accumulator + value,
				BigInteger.Zero);

		/// <inheritdoc />
		/// <summary>
		/// Calculate multiplication of elements in collection.
		/// </summary>
		/// <param name="source">Input collection.</param>
		/// <returns>Multiplication of elements in collection.</returns>
		public BigInteger Multiply(
			IEnumerable<int> source)
			=> source.Accumulate(
				(accumulator, value)
					=> accumulator * value,
				BigInteger.One);
	}
}
