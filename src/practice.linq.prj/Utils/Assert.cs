using System;

namespace Practice.Linq.Utils
{
	/// <summary>
	/// Static class that contains methods that allows 
	/// validate arguments.
	/// </summary>
	public static class Assert
	{
		/// <summary>
		/// Throws specific exception created by 
		/// <paramref name="exceptionFunc"/> of 
		/// <typeparamref name="TException"/> 
		/// type when <paramref name="fallPredicate"/> 
		/// returns <c>true</c>.
		/// </summary>
		/// <typeparam name="TException">
		/// Type of thrown exception.
		/// </typeparam>
		/// <param name="fallPredicate">
		/// Function that specified when exception should thrown.
		/// </param>
		/// <param name="exceptionFunc">
		/// Function that should construct needed exception.
		/// </param>
		public static void ThrowIf<TException>(
			Func<bool> fallPredicate,
			Func<TException> exceptionFunc) 
				where TException : Exception
		{
			if (fallPredicate())
				throw exceptionFunc();
		}

		/// <summary>
		/// Throws specific exception created by 
		/// <paramref name="exceptionFunc"/> of 
		/// <typeparamref name="TException"/> 
		/// type when <paramref name="value"/> less or equals zero.
		/// </summary>
		/// <typeparam name="TException">
		/// Type of thrown exception.
		/// </typeparam>
		/// <param name="value">Checked value.</param>
		/// <param name="exceptionFunc">
		/// Function that should construct needed exception.
		/// </param>
		public static void ThrowIfLessOrEqualsZero<TException>(
			long value,
			Func<TException> exceptionFunc)
				where TException : Exception
		{
			if (value <= 0)
				throw exceptionFunc();
		}

		/// <summary>
		/// Throws specific exception created by 
		/// <paramref name="exceptionFunc"/> of 
		/// <typeparamref name="TException"/> 
		/// type when <paramref name="value"/> less zero.
		/// </summary>
		/// <typeparam name="TException">
		/// Type of thrown exception.
		/// </typeparam>
		/// <param name="value">Checked value.</param>
		/// <param name="exceptionFunc">
		/// Function that should construct needed exception.
		/// </param>
		public static void ThrowIfLessZero<TException>(
			long value,
			Func<TException> exceptionFunc)
				where TException : Exception
		{
			if (value < 0)
				throw exceptionFunc();
		}

		/// <summary>
		/// Throws <seealso cref="ArgumentNullException"/> 
		/// when <paramref name="value"/> is null.
		/// </summary>
		/// <typeparam name="TObject">Type of object.</typeparam>
		/// <param name="value">Value of object.</param>
		/// <param name="argName">Name of argument.</param>
		/// <param name="msg">
		/// Optional message given with exception.
		/// </param>
		public static void ThrowIfNull<TObject>(
			TObject value,
			string argName,
			string msg = "")
				where TObject : class
		{
			if (value == null)
				throw new ArgumentNullException(
					argName,
					string.IsNullOrWhiteSpace(msg)
						? $"{argName} shouldn't be null"
						: msg);
		}
	}
}