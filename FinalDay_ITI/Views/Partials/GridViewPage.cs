namespace FinalDay_ITI.Views.Partials;

partial class GridViewPage : UserControl
{
    public event EventHandler<DataGridView>? OnClickBtns;

    private readonly Func<object> _dataSet;

    public GridViewPage(Func<object> dataSet, bool Buttons = true)
    {
        InitializeComponent();

        AddBtn.Visible = Buttons;
        EditBtn.Visible = Buttons;
        DeleteBtn.Visible = Buttons;

        _dataSet = dataSet;

        Dock = DockStyle.Fill;
        Visible = false;
    }

    private void GridViewPage_Load(object sender, EventArgs e)
    {
        Refresh();

        var columns = new string[dataGridView.ColumnCount];
        for (var i = 0; i < columns.Length; i++)
            columns[i] = dataGridView.Columns[i].Name;

        comboBox1.DataSource = columns;
    }

    public override void Refresh()
    {
        base.Refresh();
        dataGridView.DataSource = _dataSet();
        EditBtn.Enabled = dataGridView.Rows.Count > 0;
    }

    private void Btns_Click(object sender, EventArgs e) => OnClickBtns?.Invoke(sender, dataGridView);

    private void DataGridView_DataSourceChanged(object sender, EventArgs e)
    {
        bool Enabled = dataGridView.Rows.Count > 0;
        EditBtn.Enabled = Enabled;
        DeleteBtn.Enabled = Enabled;
        comboBox1.Enabled = Enabled;
        textBox1.Enabled = Enabled;
        NoDataLabel.Visible = !Enabled;
    }
}
