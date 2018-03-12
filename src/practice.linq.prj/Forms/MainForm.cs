using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

using Practice.Linq.IEnumerableUtils;

namespace Practice.Linq.Forms
{
	/// <inheritdoc />
	/// <summary>
	/// Represent the main window of application.
	/// </summary>
	public partial class MainForm : Form
	{

		#region .ctor

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="MainForm"/> class.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			Converter = new LinqEnumerableConverter();

			_countNumBox.Maximum = int.MaxValue;
			_maximumNumBox.Maximum = int.MaxValue;

			_generateBtn.Click += (o, e) => Generate();
			_processBtn.Click += (o, e) => Process();

			_ownImplRadioBtn.CheckedChanged += (o, e) =>
				Converter = ((RadioButton) o).Checked 
				? new OwnEnumerableConverter() 
					as IEnumerableConverter<int, BigInteger> 
				: new LinqEnumerableConverter() 
					as IEnumerableConverter<int, BigInteger>;

			_linqImplRadioBtn.CheckedChanged += (o, e) =>
				Converter = ((RadioButton)o).Checked
					? new LinqEnumerableConverter()
						as IEnumerableConverter<int, BigInteger>
					: new OwnEnumerableConverter()
						as IEnumerableConverter<int, BigInteger>;
		}
		#endregion

		#region Properties

		/// <summary>
		/// Gets using implementation for working with
		/// collection.
		/// </summary>
		/// <value>
		/// Using implementation for working with
		/// collection.
		/// </value>
		public IEnumerableConverter<int, BigInteger> Converter
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets list of generated values.
		/// </summary>
		/// <value>
		/// List of generated values.
		/// </value>
		public IList<int> GeneratedValues { get; private set; }

		/// <summary>
		/// Gets or sets count of generated value.
		/// </summary>
		/// <value>
		/// Count of generated values.
		/// </value> 
		public int Count
		{
			get => (int)_countNumBox.Value;
			set => _countNumBox.Value = value;
		}

		/// <summary>
		/// Gets or sets maximum value of generated item.
		/// </summary>
		/// <value>
		/// Maximum value of generated item
		/// </value> 
		public int Maximum
		{
			get => (int)_maximumNumBox.Value;
			set => _maximumNumBox.Value = value;
		}

		#endregion

		#region Functions

		/// <summary>
		/// Generates random collection.
		/// </summary>
		private void Generate()
		{
			GeneratedValues =
				Converter.Generate(Count, Maximum)
					.ToList();
			_processBtn.Enabled = true;
			_generatedItemsListBox.DataSource = GeneratedValues;
			_processedItemsListBox.DataSource = null;
		}

		/// <summary>
		/// Works with random collection.
		/// </summary>
		private void Process()
		{
			var values = Converter
				.Process(GeneratedValues)
				.ToList();
			_processedItemsListBox.DataSource = values;

			if (values.Any())
			{
				var sum = Converter.Sum(values);
				var multiply = Converter.Multiply(values);

				MessageBox.Show(
					$"Сумма: {sum}\n" +
					$"Произведение: {multiply}",
					"Результат",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(
					"Отфильтрованная коллекция пуста!",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}

		}

		#endregion

	}
}
