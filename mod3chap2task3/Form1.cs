namespace mod3chap2task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvResults.Columns.Add("Number", "Номер");
            dgvResults.Columns.Add("Value", "Значення");
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            int limit = int.Parse(txtLimit.Text);

            List<ulong> results = await Task.Run(() => CalculateFibonacci(limit));

            dgvResults.Rows.Clear();

            for (int i = 0; i < results.Count; i++)
            {
                dgvResults.Rows.Add(i, results[i]);
            }
        }

        private List<ulong> CalculateFibonacci(int limit)
        {
            List<ulong> results = new List<ulong>();
            ulong a = 0;
            ulong b = 1;

            results.Add(a);
            results.Add(b);

            for (int i = 2; i <= limit; i++)
            {
                ulong c = a + b;
                results.Add(c);
                a = b;
                b = c;
            }

            return results;
        }
    }
}