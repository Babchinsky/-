using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Reciepes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Tuple<string, FlowDocument>> docs;
        public MainWindow()
        {
            InitializeComponent();

            docs = new List<Tuple<string, FlowDocument>>();

            CreateExamples();
            AddToList();
        }

        public void AddToList()
        {
            foreach (var item in docs)
            {
                ls.Items.Add(item.Item1);
            }
        }

        public void CreateExamples()
        {
            try
            {
                Run run1 = new Run("ШОКОЛАДНЫЙ ФОНДАН В МИКРОВОЛНОВКЕ");
                Paragraph paragraph1 = new Paragraph(new Bold(run1));
                paragraph1.FontSize = 30;
                paragraph1.TextAlignment = TextAlignment.Center;
                //paragraph1.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Paragraph paragraph2 = new Paragraph();
                //картинка
                Image img = new Image();
                BitmapImage bimg = new BitmapImage();
                bimg.BeginInit();
                bimg.UriSource = new Uri("Fondan.jpg", UriKind.Relative);
                bimg.EndInit();
                img.Source = bimg;
                BlockUIContainer block = new BlockUIContainer(img);
                Figure fig = new Figure(block);
                fig.Width = new FigureLength(200);
                fig.HorizontalAnchor = FigureHorizontalAnchor.ContentRight;

                //текст
                Run run2 = new Run();
                run2.Text = "Изумительно вкусный шоколадный десерт за 5 минут - это реальность! Наверное, фондан - это самый вкусный шоколадный десерт, который только существует в мире! Да, я настоящий фанат этого лакомства))) Он всегда нравится родным и гостям - от него непременно все в восторге, ну при условии, конечно, любви к темному, черному шоколаду. А теперь я научилась готовить любимую сладость в микроволновке - быстро, просто, буквально 5 минут... и можно наслаждаться вкусом!";
                paragraph2.Inlines.Add(fig);
                paragraph2.Inlines.Add(run2);

                Run run3 = new Run();
                run3.Text = "1. Первым делом соедините все сухие ингредиенты. Используйте для этого миску средних размеров.\r\n2. К смеси добавьте молоко и масло, перемешайте до однородности. Это важно - следите, чтобы не образовалось комочков в тесте.\r\n3. Возьмите керамическую кружку объемом не менее 400 мл, чтобы тесто имело достаточно пространства для подъема и не перелилось при выпекании через край.\r\n4. Насыпьте в центр кружки шоколад и придавите его ложкой, погружая в тесто.\r\n5. Постелите на поддон бумажное полотенце, на которое установите кружку. Эта мера позволит не запачкать технику, если тесто все-таки немного убежит.\r\n6. Выпекайте фондан в микроволновке в течение 70 секунд на самой высокой мощности (в моей микроволновке это 950 Вт). Учтите, что все микроволновые печи отличаются друг от друга, поэтому вам, возможно, придется, поэкспериментировать, чтобы получить желаемый результат. Попробуйте сначала выставить меньшее время, а после допечь десерт. Если вы будете печь фондан слишком долго, жидкая серединка может не получиться.\r\n7. Извлеките кружку из микроволновки и наслаждайтесь!";
                Paragraph paragraph3 = new Paragraph(run3);

                //ссылки
                Run run4 = new Run("Материал взято с ");
                Hyperlink hp = new Hyperlink(new Run("https://1000.menu/cooking/19459-fondan-v-mikrovolnovke"));
                hp.NavigateUri = new Uri("https://1000.menu/cooking/19459-fondan-v-mikrovolnovke");
                Paragraph paragraph4 = new Paragraph();
                paragraph4.Inlines.Add(run4);
                paragraph4.Inlines.Add(hp);

                FlowDocument doc = new FlowDocument();
                doc.Blocks.Add(paragraph1);
                doc.Blocks.Add(paragraph2);
                doc.Blocks.Add(paragraph3);
                doc.Blocks.Add(paragraph4);
                docs.Add(new Tuple<string, FlowDocument>(run1.Text, doc));

            }
            catch
            {

            }
            try
            {
                Run run1 = new Run("ТРИО - ПРОСТОЙ И ВКУСНЫЙ СОЛИДНЫЙ САЛАТ ЗА 5 МИНУТ");
                Paragraph paragraph1 = new Paragraph(new Bold(run1));
                paragraph1.FontSize = 30;
                paragraph1.TextAlignment = TextAlignment.Center;
                //paragraph1.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Paragraph paragraph2 = new Paragraph();
                //картинка
                Image img = new Image();
                BitmapImage bimg = new BitmapImage();
                bimg.BeginInit();
                bimg.UriSource = new Uri("Trio.jpg", UriKind.Relative);
                bimg.EndInit();
                img.Source = bimg;
                BlockUIContainer block = new BlockUIContainer(img);
                Figure fig = new Figure(block);
                fig.Width = new FigureLength(200);
                fig.HorizontalAnchor = FigureHorizontalAnchor.ContentRight;

                //текст
                Run run2 = new Run();
                run2.Text = "Быстро, сытно, вкусно и просто. Всего 3 ингредиента. В былые времена его продавали в маленьких рижских кафе, которыми был усеян старый город. Относительно недорогой и очень сытный салат был просто находкой для молодежи и студентов, так как для вторых блюд - средств не всегда хватало.";
                paragraph2.Inlines.Add(fig);
                paragraph2.Inlines.Add(run2);

                Run run3 = new Run();
                run3.Text = "1. НАРЕЗКА Интересное сочетание кубиков из трех основных ингредиентов дает интересное блюдо за очень короткое время. Наверное, в этом главное преимущество салата. Возможно его название в разных регионах повторяется, но ничего общего с салатом «Якутия» не имеет.\r\n2. Все приготовление готовых продуктов заключается в ровной нарезке сыра и ветчины. Поэтому указанное время проверено жизненным опытом.\r\n3. Кубики должным быть примерно одного размера, как фасоль. Это не то чтобы правильно, скорее сочетание и смешивание продуктов происходит лучше, если они одинаковые по форме.\r\n4. После нарезки и смешивания, салат можно заправить студенческим соусом - майонезом (по желанию),свежей зеленью (по желанию и наличию) и т.д.";
                Paragraph paragraph3 = new Paragraph(run3);

                //ссылки
                Run run4 = new Run("Материал взято с ");
                Hyperlink hp = new Hyperlink(new Run("https://1000.menu/cooking/26771-trio-prostoi-i-vkusnyi-solidnyi-salat-za-5-minut"));
                hp.NavigateUri = new Uri("https://1000.menu/cooking/26771-trio-prostoi-i-vkusnyi-solidnyi-salat-za-5-minut");
                Paragraph paragraph4 = new Paragraph();
                paragraph4.Inlines.Add(run4);
                paragraph4.Inlines.Add(hp);

                FlowDocument doc = new FlowDocument();
                doc.Blocks.Add(paragraph1);
                doc.Blocks.Add(paragraph2);
                doc.Blocks.Add(paragraph3);
                doc.Blocks.Add(paragraph4);
                docs.Add(new Tuple<string, FlowDocument>(run1.Text, doc));

            }
            catch
            {

            }
            try
            {
                Run run1 = new Run("ТВОРОГ С ЯЙЦОМ ЗАВТРАК ПП ЗА 5 МИНУТ");
                Paragraph paragraph1 = new Paragraph(new Bold(run1));
                paragraph1.FontSize = 30;
                paragraph1.TextAlignment = TextAlignment.Center;
                //paragraph1.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                Paragraph paragraph2 = new Paragraph();
                //картинка
                Image img = new Image();
                BitmapImage bimg = new BitmapImage();
                bimg.BeginInit();
                bimg.UriSource = new Uri("Tvorog.jpg", UriKind.Relative);
                bimg.EndInit();
                img.Source = bimg;
                BlockUIContainer block = new BlockUIContainer(img);
                Figure fig = new Figure(block);
                fig.Width = new FigureLength(200);
                fig.HorizontalAnchor = FigureHorizontalAnchor.ContentRight;

                //текст
                Run run2 = new Run();
                run2.Text = "Полезное и вкусное начало дня! Быстро и просто! Творог с яйцом на завтрак ПП готовится в микроволновке за 5 минут. Этот рецепт – палочка-выручалочка при недостатке времени. Питательная, сбалансированная по составу нежная творожная запеканка зарядит организм здоровой энергией на весь день.";
                paragraph2.Inlines.Add(fig);
                paragraph2.Inlines.Add(run2);

                Run run3 = new Run();
                run3.Text = "1. Как сделать творог с яйцом на завтрак ПП за 5 минут? Подготовьте необходимые продукты. Творог можно взять жирностью 5-9%. Чем выше жирность творога, тем вкуснее и более питательным получится блюдо. Главное, чтобы творог был свежим, некислым и нежестким. Яйца используйте категории не менее С1.\r\nИзюм тщательно помойте и распарьте. Как правильно распарить изюм? Залейте хорошо промытый изюм горячей водой и оставьте на 10-15 минут. За это время он станет мягким. Слейте воду и обсушите его бумажными полотенцами. Можно взять любые сухофрукты (курагу, чернослив) или вяленые ягоды (клюкву, вишню).\r\n3. В миске соедините творог, яйца, сахар и муку. Обязательно мойте яйца перед использованием, так как даже на кажущейся чистой скорлупе могут находиться вредные бактерии. Сахар добавляйте по вкусу, учитывая сладкий вкус сухофруктов. Вместо сахара можно использовать также сахарозаменитель, который не боится термической обработки.\r\n4. Перемешайте творожную массу до однородности.\r\n5. Чистый, просушенный изюм добавьте в полученную массу. Если используете крупные сухофрукты, то предварительно их мелко нарежьте ножом.\r\n6. В миску, подходящую для приготовления в микроволновой печи, добавьте воду, чтобы запеканка во время приготовления не присохла.\r\n7.Выложите творожную массу в миску и разровняйте.\r\n8.Поставьте творог с яйцом в микроволновую печь. Я запекала завтрак при мощности печи 750 W. По времени приготовления будет достаточно 3 минут. Имейте в виду, что микроволновки работают не одинаково. Время приготовления и рекомендуемая мощность могут отличаться от заявленных в рецепте. Читайте инструкцию к вашему прибору и учитывайте особенности именно вашей техники\r\n9.Готовая запеканка уплотнится. Достаньте миску из микроволновки, используя кухонные варежки, чтобы не обжечься.\r\n10.Миску с запеканкой переверните на тарелку. Можно подавать как в остывшем, так и в теплом виде. Приятного аппетита!";
                Paragraph paragraph3 = new Paragraph(run3);

                //ссылки
                Run run4 = new Run("Материал взято с ");
                Hyperlink hp = new Hyperlink(new Run("https://1000.menu/cooking/66724-tvorog-s-yaicom-zavtrak-pp-za-5-minut"));
                hp.NavigateUri = new Uri("https://1000.menu/cooking/66724-tvorog-s-yaicom-zavtrak-pp-za-5-minut");
                Paragraph paragraph4 = new Paragraph();
                paragraph4.Inlines.Add(run4);
                paragraph4.Inlines.Add(hp);

                FlowDocument doc = new FlowDocument();
                doc.Blocks.Add(paragraph1);
                doc.Blocks.Add(paragraph2);
                doc.Blocks.Add(paragraph3);
                doc.Blocks.Add(paragraph4);
                docs.Add(new Tuple<string, FlowDocument>(run1.Text, doc));

            }
            catch
            {

            }
        }

        private void ls_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ls.SelectedItem != null)
            {
                DocReader.Document = docs[ls.SelectedIndex].Item2;

            }
        }
    }
}
