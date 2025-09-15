namespace WFA25091501;

public partial class FrmMain : Form
{
    private Dictionary<string, object> alapTulajdonsagok;


    public FrmMain()
    {
        InitializeComponent();

        AlapallapotMentese();

        btnKekBetu.Click += BtnKekBetu_Click;
        btnFeherHatter.Click += BtnFeherHatter_Click;
        btnTorol.Click += BtnTorol_Click;
        btnBalKozep.Click += BtnBalKozep_Click;
        btnJobbKozep.Click += BtnJobbKozep_Click;
        btnKozepKozep.Click += BtnKozepKozep_Click;
        btnNagybetus.Click += BtnNagybetus_Click;
        btnNagyit.Click += BtnNagyit_Click;
        btnKicsinyit.Click += BtnKicsinyit_Click;
        btnAlaphelyzet.Click += BtnAlaphelyzet_Click;
        btnKilepes.Click += BtnKilepes_Click;
    }

    private void AlapallapotMentese()
    {
        alapTulajdonsagok = new()
        {
            { "háttérszín", lblSzoveg.BackColor },
            { "elõszín", lblSzoveg.ForeColor },
            { "font", lblSzoveg.Font },
            { "igazítás", lblSzoveg.TextAlign },
            { "szöveg", lblSzoveg.Text },
        };
    }

    private void BtnKilepes_Click(object? sender, EventArgs e)
        => Application.Exit();

    private void BtnAlaphelyzet_Click(object? sender, EventArgs e)
    {
        lblSzoveg.BackColor = (Color)alapTulajdonsagok["háttérszín"];
        lblSzoveg.ForeColor = (Color)alapTulajdonsagok["elõszín"];
        lblSzoveg.Text = (string)alapTulajdonsagok["szöveg"];
        lblSzoveg.TextAlign = (ContentAlignment)alapTulajdonsagok["igazítás"];
        lblSzoveg.Font = (Font)alapTulajdonsagok["font"];

        //Application.Restart();
    }

    private void BtnKicsinyit_Click(object? sender, EventArgs e)
    {
        if (lblSzoveg.Font.Size <= 2) return;

        float aktEmSize = lblSzoveg.Font.Size;
        lblSzoveg.Font = new(
            family: lblSzoveg.Font.FontFamily,
            emSize: aktEmSize -= 2,
            style: lblSzoveg.Font.Style);
    }

    private void BtnNagyit_Click(object? sender, EventArgs e)
    {
        float aktEmSize = lblSzoveg.Font.Size;
        lblSzoveg.Font = new(
            family: lblSzoveg.Font.FontFamily,
            emSize: aktEmSize += 2,
            style: lblSzoveg.Font.Style);
    }

    private void BtnNagybetus_Click(object? sender, EventArgs e)
        => lblSzoveg.Text = lblSzoveg.Text.ToUpper();


    private void BtnKozepKozep_Click(object? sender, EventArgs e)
        => lblSzoveg.TextAlign = ContentAlignment.MiddleCenter;

    private void BtnJobbKozep_Click(object? sender, EventArgs e)
        => lblSzoveg.TextAlign = ContentAlignment.MiddleRight;

    private void BtnBalKozep_Click(object? sender, EventArgs e) 
        => lblSzoveg.TextAlign = ContentAlignment.MiddleLeft;

    private void BtnTorol_Click(object? sender, EventArgs e)
    {
        if (lblSzoveg.Text.Length <= 0) return;
        lblSzoveg.Text = lblSzoveg.Text[..^1];
    }

    private void BtnFeherHatter_Click(object? sender, EventArgs e)
        => lblSzoveg.BackColor = Color.White;

    private void BtnKekBetu_Click(object? sender, EventArgs e) 
        => lblSzoveg.ForeColor = Color.Blue;
}
