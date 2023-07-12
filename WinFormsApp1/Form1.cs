using Logic.ContainerExample;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    private readonly IProcessor _processor;

    public Form1(IProcessor processor)
    {
        _processor = processor ?? throw new ArgumentNullException(nameof(processor));
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _processor.ProcessAsync(CancellationToken.None).Wait();
    }
}
