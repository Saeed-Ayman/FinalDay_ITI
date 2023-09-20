using FinalDay_ITI.Controllers;
using FinalDay_ITI.Requests;

namespace FinalDay_ITI.Views.Partials;

partial class GridViewPage : UserControl
{
    public event EventHandler<DataGridView>? OnClickBtns;

    private readonly string _controller;
    private readonly object? _additionalData;

    public GridViewPage(string controller, object? additionalData = null, bool Buttons = true)
    {
        InitializeComponent();

        AddBtn.Visible = Buttons;
        EditBtn.Visible = Buttons;
        DeleteBtn.Visible = Buttons;

        _controller = controller;
        _additionalData = additionalData;

        Dock = DockStyle.Fill;
        Visible = false;
    }

    private void GridViewPage_Load(object sender, EventArgs e)
    {
        Refresh();

        var columns = new string[dataGridView.ColumnCount];
        for (var i = 0; i < columns.Length; i++)
            columns[i] = dataGridView.Columns[i].Name;

        FieldsComboBox.DataSource = columns;
    }

    public override void Refresh()
    {
        base.Refresh();
        dataGridView.DataSource = SearchController.Index(_controller, _additionalData, FieldsComboBox.SelectedValue);
        EditBtn.Enabled = dataGridView.Rows.Count > 0;
    }

    private void DataGridView_DataSourceChanged(object sender, EventArgs e)
    {
        bool Enabled = dataGridView.Rows.Count > 0;
        EditBtn.Enabled = Enabled;
        DeleteBtn.Enabled = Enabled;
        FieldsComboBox.Enabled = Enabled || !SearchTxt.Text.IsEmpty();
        SearchTxt.Enabled = Enabled || !SearchTxt.Text.IsEmpty();
        NoDataLabel.Visible = !Enabled;
    }

    private void Btns_Click(object sender, EventArgs e) => OnClickBtns?.Invoke(sender, dataGridView);
    private void SearchTxt_TextChanged(object sender, EventArgs e)
        => dataGridView.DataSource = SearchController.Index(_controller, _additionalData, FieldsComboBox.SelectedValue, SearchTxt.Text);
    private void FieldsComboBox_SelectedIndexChanged(object sender, EventArgs e) => SearchTxt.Text = string.Empty;
}
