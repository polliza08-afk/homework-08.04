using System.Security.Cryptography.X509Certificates;
namespace Pasxa
{
    public partial class MainForm : Form
    {
        List<MyPasxa> myPasxa = new List<MyPasxa>();
        public MainForm()
        {
            InitializeComponent();
            lvPasxy.LargeImageList = new ImageList();
            lvPasxy.LargeImageList.ImageSize = new Size(150, 115);
            lvPasxy.MultiSelect = false;
            //lvExplorer.ListViewItemSorter = new ListViewIndexComparer();
            lvPasxy.InsertionMark.Color = Color.Green;
            lvPasxy.AllowDrop = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            myPasxa.Add(new MyPasxa
            {
                name = "Малятко",
                weight = 80,
                producer = "Скиба",
                image = "images\\4VhEUAeRlxgiwe2lvZz-2e2TYWBZmm9U.png"
            });
            myPasxa.Add(new MyPasxa
            {
                name = "Бурштинова",
                weight = 350,
                producer = "Скиба",
                image = "images\\2.png"
            });
            myPasxa.Add(new MyPasxa
            {
                name = "Три шоколади",
                weight = 300,
                producer = "Скиба",
                image = "images\\choc.png"
            });
            foreach (var p in myPasxa)
            {
                string key = Guid.NewGuid().ToString();
                ListViewItem item = new ListViewItem();
                item.Tag = p.name;
                item.Text = p.name; //назва пасхи. Відображається в ListView
                item.ImageKey = key;
                lvPasxy.LargeImageList.Images.Add(key, Image.FromFile(p.image));
                lvPasxy.Items.Add(item);
            }
        }

        private void lvPasxy_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvPasxy.SelectedItems.Count == 0)
                return;

            var item = lvPasxy.SelectedItems[0];

            MyPasxa selected = (MyPasxa)item.Tag;

            InfoForm form = new InfoForm(selected);
            form.ShowDialog();
        }
    }
}
