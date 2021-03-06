using ForExperiments.Data;
using ForExperiments.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ForExperiments.Views.Questions
{
    /// <summary>
    /// Логика взаимодействия для SeniorQuestions.xaml
    /// </summary>
    public partial class SeniorQuestions : Window
    {
        public SeniorQuestions()
        {
            InitializeComponent();

            this.DataContext = new ViewModels.SeniorQuestionsViewModel();

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
            GeneralQuestionsList.ClearSeniorContent();
            DBTableContents.Text = "";

            ListTab.Focus();
            ForExperimentsContext db = new();
            foreach (var i in db.SeniorQuestions)
            {
                GeneralQuestionsList.SeniorContent.Add(new List<string> { i.Question, i.Answer });
            }

            for (int i = 0; i < GeneralQuestionsList.SeniorContent.Count; i++)
            {
                DBTableContents.Text += $"{i + 1}) {GeneralQuestionsList.SeniorContent[i][0]}\n" +
                                        $"    ###   Ответ:   ###\n" +
                                        $"{GeneralQuestionsList.SeniorContent[i][1]}\n\n";
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
                SeniorQuestion seniorQuestion = new()
                {
                    Question = QuestionInput.Text,
                    Answer = AnswerInput.Text
                };

                dbContents.SeniorQuestions.Add(seniorQuestion);
                dbContents.SaveChanges();
            }
            MessageBox.Show($"Данные записаны...");
            QuestionInput.Text = "";
            AnswerInput.Text = "";
        }

        #endregion AddTab Item buttons
    }
}