using ReadTextFileProduct.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ReadTextFileProduct.Actions
{
    public class ReadFileTextAction
    {
        public List<ContentFileModel> ReadFileText(string path)
        {
            List<ContentFileModel> list = new List<ContentFileModel>();
            CheckNameConsumerAction checkNameConsumerAction = new CheckNameConsumerAction();

            try
            {
                using (var reader = new StreamReader(path))
                {
                    string line;

                    string consumerName = "";
                    string productName = "";
                    int amount = 0;
                    double price = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line != "")
                        {
                            bool checkNameConsumer = checkNameConsumerAction.CheckNameConsumer(line);
                            if(checkNameConsumer == true)
                            {
                                consumerName = line.Trim();
                            }
                            else
                            {
                                line = line.Trim();

                                string[] tempLine = line.Split(new char[] {' '}, StringSplitOptions.None);

                                string tempAmount = tempLine[0];
                                string tempPrice = tempLine[tempLine.Length - 1];

                                if (tempPrice[0] == 'x' || tempPrice[0] == 'X')
                                {
                                    tempPrice = tempPrice.Substring(1);
                                }

                                string tempProductName = "";

                                for(int i = 1; i< tempLine.Length - 1; i++)
                                {
                                    tempProductName += tempLine[i].Trim() + " ";
                                }

                                try
                                {
                                    amount = int.Parse(tempAmount);
                                }
                                catch(Exception ex)
                                {
                                    amount = 0;
                                    //MessageBox.Show(ex.Message);
                                }
                                try
                                {
                                    price = double.Parse(tempPrice);
                                }
                                catch(Exception ex)
                                {
                                    price = 0;
                                    tempProductName += tempPrice;
                                    //MessageBox.Show(ex.Message);
                                }

                                ContentFileModel el = new ContentFileModel();

                                el.Name = consumerName;
                                el.NameProduct = tempProductName;
                                el.Amount = amount == 0 ? "" : amount.ToString();
                                el.Price = price == 0 ? "" : price.ToString();

                                list.Add(el);
                                
                            }
                        }
                    }

                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }


            return list;

        }
    }
}
