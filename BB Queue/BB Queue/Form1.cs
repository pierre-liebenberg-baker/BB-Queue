
namespace BB_Queue
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      InitializeDataGridView();
    }

    private static System.Timers.Timer timer;

    public static DateTime startTime;
    public static DateTime endTime;
    public static DateTime simulatedTime = DateTime.Now;

    public static int posCount = 0;
    public static int mrDCount = 0;

    Random random = new Random();

    OrderManager om = new OrderManager();

    public void SetTimer()
    {
      startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
      endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);
      simulatedTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 55, 0);

      timer = new System.Timers.Timer();
      timer.Interval = 1000;
      timer.Elapsed += TimerElapsed;
      timer.Start();
    }

    private void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
      simulatedTime = simulatedTime.AddMinutes(1);
      ModifyText(timeValue, simulatedTime.ToString("HH:mm"));
      Invoke(() =>
      {
        ModifyText(toyCountTextBox, om.toysAvailable.ToString());
      });
      
      if (simulatedTime >= startTime && simulatedTime <= endTime)
      {
        //GENERATE ORDERS
        Invoke(() =>
        {
          GenerateQueue();
        });

      }

      if (om.Orders.Count > 0)
      {
        //START PROCESSING
        Invoke(() =>
        {
          om.MarkAsCollected(simulatedTime);
        });
      }

    }

    public void GenerateQueue()
    {

      int orderCountRandom = random.Next(1, 3);

      for (int i = 0; i < orderCountRandom; i++)
      {
        om.CreateOrder((OrderType)random.Next(0, 2), simulatedTime);
        dgvReceivedOrders.Invoke(() =>
        {
          dgvReceivedOrders.DataSource = om.Orders;
        });
      }

    }

    public void ModifyText(TextBox txtBox, string text)
    {
      txtBox.Invoke(new Action(() =>
      {
        txtBox.Text = text;
      }));
    }

    

    private void startButton_Click(object sender, EventArgs e)
    {
      om.Orders.Clear();
      om.CollectedOrders.Clear();
      dgvReceivedOrders.DataSource = om.Orders;
      dgvCompletedOrders.DataSource = om.CollectedOrders;
      SetTimer();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      timer.Stop();
    }

    private void timeValue_TextChanged(object sender, EventArgs e)
    {

    }

    private void InitializeDataGridView()
    {
      dgvReceivedOrders.DataSource = om.Orders;
      dgvCompletedOrders.DataSource = om.CollectedOrders;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      timer.Stop();
    }
  }
}