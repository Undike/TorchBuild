using System.Text.Json;
using TorchBuild.Models;

namespace TorchBuild
{
    public partial class Form1 : Form
    {
        private FlowLayoutPanel heroPanel;
        private Label heroInfoLabel;
        private PictureBox selectedHeroPic;
        public Form1()
        {
            InitializeComponent();
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            // 🔹 Панель для текста (заголовок "Выбор героя")
            Panel textPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.LightGray,
                Padding = new Padding(10)
            };
            Controls.Add(textPanel);

            heroInfoLabel = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 18, FontStyle.Bold),
                Text = "Выбор героя",
                TextAlign = ContentAlignment.MiddleCenter,
            };
            textPanel.Controls.Add(heroInfoLabel);

            textPanel.Padding = new Padding(0, 0, 0, 30); // Добавляем пространство под текстом

            FlowLayoutPanel heroPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top, // Размещаем ниже текстовой панели
                AutoSize = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10),
            };
            Controls.Add(heroPanel);
            heroPanel.Location = new Point(heroPanel.Location.X, textPanel.Bottom + 20); // Смещаем вручную ниже текста


            LoadHeroes(heroPanel); // Передаём `FlowLayoutPanel` вместо `TableLayoutPanel`
        }

        private void LoadHeroes(FlowLayoutPanel heroPanel) // Теперь принимаем FlowLayoutPanel
        {
            string basePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string jsonPath = Path.Combine(basePath, "Data", "Heroes", "Heroes.json");

            if (!File.Exists(jsonPath))
            {
                MessageBox.Show($"Файл JSON не найден: {jsonPath}");
                return;
            }

            string json = File.ReadAllText(jsonPath);
            using JsonDocument doc = JsonDocument.Parse(json);
            var heroes = JsonSerializer.Deserialize<List<Hero>>(doc.RootElement.GetProperty("heroes").ToString());

            if (heroes == null || heroes.Count == 0)
            {
                MessageBox.Show("Героев не найдено.");
                return;
            }

            foreach (var hero in heroes)
            {
                string imgPath = Path.Combine(basePath, hero.SubClasses.FirstOrDefault()?.ImagePath ?? "");
                PictureBox heroPic = new PictureBox
                {
                    Size = new Size(100, 100),
                    BorderStyle = BorderStyle.FixedSingle,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                    Tag = hero
                };

                if (File.Exists(imgPath))
                {
                    heroPic.Image = Image.FromFile(imgPath);
                }
                else
                {
                    heroPic.BackColor = Color.Gray;
                }

                heroPic.Click += Hero_Click;
                heroPanel.Controls.Add(heroPic); // Заменяем `.Add(heroPic, col, row)` на `.Add(heroPic)`
            }
        }



        private void Hero_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox picBox && picBox.Tag is Hero selectedHero)
            {
                heroInfoLabel.Text = $"{selectedHero.Name}: {string.Join(", ", selectedHero.SubClasses.Select(s => s.Name))}";

                // 🔹 Снимаем выделение с предыдущего героя
                if (selectedHeroPic != null)
                {
                    selectedHeroPic.Paint -= HeroPic_Paint; // Убираем обработчик рисования рамки
                    selectedHeroPic.Invalidate(); // Перерисовываем без выделения
                }

                // 🔹 Выделяем нового героя
                selectedHeroPic = picBox;
                selectedHeroPic.Paint += HeroPic_Paint; // Добавляем обработчик рисования рамки
                selectedHeroPic.Invalidate(); // Перерисовываем для обновления
            }
        }

        // 🔹 Рисуем рамку вручную
        private void HeroPic_Paint(object sender, PaintEventArgs e)
        {
            if (sender is PictureBox picBox)
            {
                using (Pen pen = new Pen(Color.Black, 12)) // Цвет и толщина рамки
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, picBox.Width - 1, picBox.Height - 1);
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
//using JsonDocument doc = JsonDocument.Parse(json);
//var heroes = JsonSerializer.Deserialize<List<Hero>>(doc.RootElement.GetProperty("heroes").ToString());


//Label skillInfoLabel = new Label
//{
//    Dock = DockStyle.Top,
//    Font = new Font("Arial", 12),
//    TextAlign = ContentAlignment.MiddleCenter
//};

//// 🔹 Наведение курсора на объект навыка
//skillIcon.MouseEnter += (s, e) => skill.ShowSkillInfo(skillInfoLabel);

//// 🔹 Уход курсора — скрываем текст
//skillIcon.MouseLeave += (s, e) => skill.HideSkillInfo(skillInfoLabel);
