using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTests
    {
        [Fact]
        public async void V_Sub_I()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "IV", "result != IV");
        }

        [Fact]
        public async void V_Sub_I_Sub_I()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "III", "result != III");
        }

        [Fact]
        public async void V_Plus_V()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "X", "result != X");
        }
        [Fact]
        public async void V_Mul_V()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonMul");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "XXV", "result != XXV");
        }
        [Fact]
        public async void X_Div_V()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonDiv = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonDiv");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonDiv.Command.Execute(buttonDiv.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "II", "result != II");
        }
        [Fact]
        public async void I_Plus_C_Sub_V()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonC = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonC");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "XCVI", "result != XCVI");
        }

        [Fact]
        public async void I_Sub_V()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }
        [Fact]
        public async void M_MUL_V()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonMul");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }
        [Fact]
        public async void X_Mul_M_Plus_V()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonMul");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }
        [Fact]
        public async void M_Sub_X_Sub_V()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "CMLXXXV", "result != CMLXXXV");
        }
        [Fact]
        public async void M_Sub_X_Result_I()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "I", "result != I");
        }
        [Fact]
        public async void X_X_X_Sub_X()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "XX", "result != XX");
        }

        [Fact]
        public async void I_I_Result_CE()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            await Task.Delay(50);
            string text = result.Text;
            Assert.True(text == "", "result != '");
        }
    }
}