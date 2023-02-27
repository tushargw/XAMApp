using Moq;
using XAMApp.ViewModels;

namespace NUnitTesting
{
	public class MVVMCalculatorTests
	{
		private MVVMCalculatorViewModel _vm;

		[SetUp]
		public void Setup()
		{
			var view = new Mock<IView>();
			_vm = new MVVMCalculatorViewModel(view.Object);
		}

		[Test]
		public void AddCommand_Test()
		{
			_vm.FirstNumber = 15; 
			_vm.SecondNumber = 10;
			_vm.AddCommand.Execute(null);
			Assert.That(_vm.Result, Is.EqualTo(25));
		}

		[Test]
		public void SubCommand_Test()
		{
			_vm.FirstNumber = 15;
			_vm.SecondNumber = 10;
			_vm.SubCommand.Execute(null);
			Assert.That(_vm.Result, Is.EqualTo(5));
		}

		[Test]
		public void MulCommand_Test()
		{
			_vm.FirstNumber = 15;
			_vm.SecondNumber = 10;
			_vm.MulCommand.Execute(null);
			Assert.That(_vm.Result, Is.EqualTo(150));
		}

		[Test]
		public void DivCommand_Test()
		{
			_vm.FirstNumber = 15;
			_vm.SecondNumber = 10;
			_vm.DivCommand.Execute(null);
			Assert.That(_vm.Result, Is.EqualTo(1.5));
		}


		[Test]
		public void DivCommand_NegativeTest()
		{
			_vm.FirstNumber = 15;
			_vm.SecondNumber = 0;
			_vm.DivCommand.Execute(null);
			Assert.That(_vm.Result, Is.EqualTo(0));
		}
	}
}