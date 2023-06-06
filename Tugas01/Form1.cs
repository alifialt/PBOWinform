using System;
using System.Data;
using Npgsql;

namespace project_alif
{
    public partial class Form1 : Form
    {
        private string connection = "Server=localhost; Port=5432; User Id=postgres; Password=Drrt11drrt; Database=query_tugas1";
        private NpgsqlConnection connect;
        private string postgresql;
        private NpgsqlCommand command;
        private DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new NpgsqlConnection(connection);
            membaca_database();
        }

        private void membaca_database()
        {
            try
            {
                connect.Open();
                postgresql = @"select laptop.nama_laptop, laptop.harga, laptop.stok, transaksi.nama_pembeli, transaksi_detail.laptop_dibeli, transaksi_detail.stok_dibeli from laptop join transaksi_detail on laptop.nama_laptop = transaksi_detail.laptop_dibeli join transaksi ON transaksi_detail.id_detail_transaksi = transaksi.id_transaksi";
                command = new NpgsqlCommand(postgresql, connect);
                table = new DataTable();
                table.Load(command.ExecuteReader());
                connect.Close();
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("Error nih: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect.Open();
            postgresql = @"select laptop.nama_laptop, laptop.harga, laptop.stok, transaksi.nama_pembeli, transaksi_detail.laptop_dibeli, transaksi_detail.stok_dibeli from laptop join transaksi_detail on laptop.nama_laptop = transaksi_detail.laptop_dibeli join transaksi ON transaksi_detail.id_detail_transaksi = transaksi.id_transaksi";
            command = new NpgsqlCommand(postgresql, connect);
            table = new DataTable();
            table.Load(command.ExecuteReader());
            connect.Close();
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string create1 = @"insert into laptop (id_laptop, nama_laptop, harga, stok) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            command = new NpgsqlCommand(create1, connect);
            command.ExecuteNonQuery();
            MessageBox.Show("Data ditambahkan!");
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            string create1 = @"insert into transaksi_detail (id_detail_transaksi, laptop_dibeli, stok_dibeli) values ('" + textBox10.Text + "','" + textBox9.Text + "','" + textBox6.Text + "')";
            command = new NpgsqlCommand(create1, connect);
            command.ExecuteNonQuery();
            MessageBox.Show("Data ditambahkan!");
            connect.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect.Open();
            string create1 = @"insert into transaksi (id_transaksi, nama_pembeli) values ('" + textBox8.Text + "','" + textBox7.Text + "')";
            command = new NpgsqlCommand(create1, connect);
            command.ExecuteNonQuery();
            MessageBox.Show("Data ditambahkan!");
            connect.Close();
        }
    }
}