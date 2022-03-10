﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ForExperiments
{
    /// <summary>
    /// Логика взаимодействия для AppsList.xaml
    /// </summary>
    public partial class AppsList : Window
    {

        public AppsList()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\cofee.jpg")));

            #region не прерывный показ текущего времени (внизу окна)
            // не прерывный показ текущего времени (внизу окна)
            var timer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 1),
                IsEnabled = true
            };
            timer.Tick += (o, t) => { TimeShow.Text = DateTime.Now.ToString(); };
            timer.Start();
            #endregion не прерывный показ текущего времени (внизу окна)
        }

        #region Welcome message box
        public string? ViewModel { get; set; }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }
        #endregion Welcome message box

        #region Menu items
        private void MenuItemEnv_Click(object sender, RoutedEventArgs e)
        {
            // работа с системными инструментами
            MessageBox.Show(
                $"System information:\nUser: {Environment.UserName}\nSystem process: {System.Diagnostics.Process.GetCurrentProcess()}\n" +
                $"Current directory: {Environment.CurrentDirectory}\nCurrent Managed Thread ID: {Environment.CurrentManagedThreadId}\n" +
                $"Logical Drives:\n{String.Join('\n', Environment.GetLogicalDrives())}\nhow much processors: {Environment.ProcessorCount}\n" +
                $"System is 64bit?: {Environment.Is64BitOperatingSystem}\nOS version: {Environment.OSVersion}\nMachine name: {Environment.MachineName}\n" +
                $".NET version: {Environment.Version}\nSystem directory: {Environment.SystemDirectory}");
        }
        private void AboutApp_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Приложение написано на C#10, .NET6, WPF\nПредназначено для личного использования, как показатель процесса обучения...");
        }
        #endregion Menu items

        #region switch tab Items
        // switch tab Items
        private void RubTabItemList_click(object sender, RoutedEventArgs e)
        {
            TabItemList.Focus();
        }

        private void RubTabItemTable_click(object sender, RoutedEventArgs e)
        {
            TabItemTable.Focus();
        }
        #endregion switch tab Items



        #region hover on list titles
        // mouse enter
        private void DescriptTitle_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DecriptionQuestionsList.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Постарался собрать вопросы, которые могут попадаться на собеседованиях C# программистов, а так же дать подробные ответы.\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";
        }

        private void DescriptTitleOne_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionOne.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Общие вопросы, которые встречаются на собеседованиях, разного уровня и знаний программистов.\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";
        }
        private void DescriptTitleTwo_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionTwo.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Чаще всего, встречающиеся вопросы на собеседованиях программистов, уровня Junior (Начинающий)\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";

        }
        private void DescriptTitleThree_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionThree.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Чаще всего, встречающиеся вопросы на собеседованиях программистов, уровня Middle (Уровень знаний по середине, между Junior и Senior)\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";

        }
        private void DescriptTitleFour_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionFour.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Чаще всего, встречающиеся вопросы на собеседованиях программистов, уровня Senior (Опытные программисты)\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";

        }
        private void DescriptTitleFive_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionFive.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Все вопросы с собеседований собраны в один тест, благодаря которому, вы можете проверить свои знания, при подготовке к собеседованию.\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";

        }
        private void MiniProjTitle_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjTitle.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Элементарные приложения, которые делают все, во время обучения программированию.\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";
        }

        private void MiniProjCalculator_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjCalculator.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Приложение - Калькулятор.\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";
        }

        private void MiniProjNotebook_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjNotebook.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Простейший блокнот.\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";
        }

        private void MiniProjCrossesAndZero_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjCrossesAndZero.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Игра в \"Крестики нолики\"\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";
        }

        private void MiniProjPasswordGenerate_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjPasswordGenerate.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Генератор паролей с разными условиями.\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";
        }

        private void MiniProjResumeCreator_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjResumeCreator.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Создатель резюме(Записываете необходимые данные и получаете готовое резюме, по шаблону)\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";
        }

        private void MiniProjPaint_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjPaint.TextDecorations = TextDecorations.Underline;
            DescriptionText.Text = "Реализация простейшего редактора для рисования.\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";
        }

        // mouse leave
        private void DescriptionTitleList_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DecriptionQuestionsList.TextDecorations = null;
        }
        private void DescriptionTitleOne_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionOne.TextDecorations = null;
        }
        private void DescriptionTitleTwo_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionTwo.TextDecorations = null;
        }
        private void DescriptionTitleThree_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionThree.TextDecorations = null;
        }
        private void DescriptionTitleFour_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionFour.TextDecorations = null;
        }
        private void DescriptionTitleFive_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            DescriptionQuestionFive.TextDecorations = null;
        }
        private void MiniProjTitle_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjTitle.TextDecorations = null;
        }

        private void MiniProjCalculator_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjCalculator.TextDecorations = null;
        }

        private void MiniProjNotebook_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjNotebook.TextDecorations = null;
        }

        private void MiniProjCrossesAndZero_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjCrossesAndZero.TextDecorations = null;
        }

        private void MiniProjPasswordGenerate_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjPasswordGenerate.TextDecorations = null;
        }

        private void MiniProjResumeCreator_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjResumeCreator.TextDecorations = null;
        }

        private void MiniProjPaint_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MiniProjPaint.TextDecorations = null;
        }
        #endregion hover on list titles


    }
}