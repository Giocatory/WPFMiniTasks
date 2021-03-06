using ForExperiments.Data;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ForExperiments.Views.Questions
{
    /// <summary>
    /// Логика взаимодействия для GeneralQuestions.xaml
    /// </summary>
    public partial class GeneralQuestions : Window
    {
        public GeneralQuestions()
        {
            InitializeComponent();

            this.DataContext = new ViewModels.GeneralQuestionsViewModel();

            this.UseLayoutRounding = true;
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\gray.png")));
            backTab.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\back.png")));
            backTabtwo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\back.png")));
        }

        #region Tabs items

        private void BackTwoClick(object sender, RoutedEventArgs e)
        {
            MainTab.Focus();
        }

        private void FocusListTab(object sender, RoutedEventArgs e)
        {
            GeneralQuestionsList.ClearContents();
            DBTableContents.Text = "";

            ListTab.Focus();
            ForExperimentsContext db = new();
            foreach (var i in db.Contents)
            {
                GeneralQuestionsList.Contents.Add(new List<string> { i.Question, i.Answer });
            }

            for (int i = 0; i < GeneralQuestionsList.Contents.Count; i++)
            {
                DBTableContents.Text += $"{i + 1}) {GeneralQuestionsList.Contents[i][0]}\n" +
                                        $"    ###   Ответ:   ###\n" +
                                        $"{GeneralQuestionsList.Contents[i][1]}\n\n";
            }
        }

        private void FocusAddTab(object sender, RoutedEventArgs e)
        {
            AddTab.Focus();
        }

        #endregion Tabs items

        #region AddTab Item buttons

        private void ClearFormInputs(object sender, RoutedEventArgs e)
        {
            QuestionInput.Text = "";
            AnswerInput.Text = "";
        }

        private void MyAddInputsToDB_Click(object sender, RoutedEventArgs e)
        {
            using (ForExperimentsContext dbContents = new())
            {
                Content conntent = new()
                {
                    Question = QuestionInput.Text,
                    Answer = AnswerInput.Text
                };

                dbContents.Contents.Add(conntent);
                dbContents.SaveChanges();
            }
            MessageBox.Show($"Данные записаны...");
            QuestionInput.Text = "";
            AnswerInput.Text = "";
        }

        #endregion AddTab Item buttons
    }
}