﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace FirehoseFinder
{
    public partial class InsertModelForm : Form
    {
        public InsertModelForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Копируем данные на основную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ok_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_tm_insert.Text))
            {
                label_tm_insert.BackColor = Color.Red;
                MessageBox.Show("Пожалуйста, выберите наименование производителя из списка или введите, при отсутствии подходящего значения.", "Пустые обязательные поля", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(textBox_model_insert.Text))
            {
                label_model_insert.BackColor = Color.Red;
                MessageBox.Show("Пожалуйста, выберите модель из списка или введите, при отсутствии подходящего значения.", "Пустые обязательные поля", MessageBoxButtons.OK);
                return;
            }
            Hide();
        }

        /// <summary>
        /// Всё стираем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_cancel_insert_Click(object sender, EventArgs e)
        {
            comboBox_tm_insert.Text = string.Empty;
            textBox_model_insert.Text = string.Empty;
            textBox_alt_insert.Text = string.Empty;
            DialogResult dr = MessageBox.Show("Обратите внимание!\r\nНезаполнение полей Производителя и Модели устройства приведёт к невозможности идентификации устройства только по данным CPU." + Environment.NewLine +
                "Нажимая \"ОК\" вы вернётесь к заполнению формы, \"Отмена\" закроет форму без сохранения данных", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Cancel) Hide();
        }

        private void ComboBox_tm_insert_TextChanged(object sender, EventArgs e)
        {
            label_tm_insert.BackColor = Color.Transparent;
        }

        private void TextBox_model_insert_TextChanged(object sender, EventArgs e)
        {
            label_model_insert.BackColor = Color.Transparent;
        }
    }
}
