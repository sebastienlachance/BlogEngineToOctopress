using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BlogEngineToOctopress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Create the routes redirection
            var redirection = new StringBuilder();

            var files = Directory.GetFiles(SourcePath, "*.xml");
            foreach (var file in files)
            {
                var content = XElement.Load(file);


                var date = Convert.ToDateTime(content.Element("pubDate").Value);
                var convertedDate = String.Format("{0}-{1}-{2}", date.Year, date.Month.ToString().PadLeft(2, '0'), date.Day.ToString().PadLeft(2, '0'));
                var slug = content.Elements("slug").First().Value;
                var filename = String.Format("{0}-{1}.markdown", convertedDate,
                                             slug.ToLower().Replace("-", "-"));

                StringBuilder sb = new StringBuilder();

                sb.AppendLine("---");
                sb.AppendLine("layout: post");
                sb.AppendLine("title: \"" + content.Element("title").Value + "\"");
                sb.AppendLine("date: " + content.Element("pubDate").Value);
                sb.AppendLine("comments: true");
                sb.AppendLine("categories: ");
                sb.AppendLine("---");
                sb.AppendLine("");
                sb.Append(content.Element("content").Value);

                redirection.Append("    r301 %r{^/post/" + slug + ".aspx?$}, '/blog/" + slug.ToLower() + "'" + Environment.NewLine);

                File.WriteAllText(Path.Combine(DestinationPath ,filename), sb.ToString(), new UTF8Encoding(false));
            }

            File.WriteAllText( Path.Combine(DestinationPath, "redirection.rb"), redirection.ToString(), Encoding.UTF8);
            MessageBox.Show("Done");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblSource.Text = folderBrowserDialog1.SelectedPath;
            SourcePath = folderBrowserDialog1.SelectedPath;
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblDestination.Text = folderBrowserDialog1.SelectedPath;
            DestinationPath = folderBrowserDialog1.SelectedPath;
        }
    }
}
