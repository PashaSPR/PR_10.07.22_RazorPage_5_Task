using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PR_10._07._22_RazorPage_5_Task.Pages
{
    public class QuoteModel : PageModel
    {
        //�������� ���� ������: ������ � �����(��'�) 
        //switch,�������� �����
        public string textQuote { get; set; }
        public string autorName { get; set; }
        //public Quote quote;

        Random rand = new Random();
        public void OnGet()
        {
            int num = rand.Next(1, 12);
            stringQuote(num);
        }

        private string stringQuote(int num)
        {
            switch (num)
            {
                case 1:
                    textQuote = "����� �� �� �� ����������� ���� � ����� ����������� ����";
                    autorName = "˳�� ��������";
                    break;
                case 2:
                    textQuote = "���� ����� �����������, ����� � ����� ������";
                    autorName = "���� ������";
                    break;
                case 3:
                    textQuote = "�� ��� �� ������ �����, ��� � ������ ���� ������";
                    autorName = "������� ���������";
                    break;
                case 4:
                    textQuote = "� ����� � ��� ���� ����� �����: � �����, ����� � ����� �� ��������, �� ����������� �� ������ \"�\"";
                    autorName = "������ ���������";
                    break;
                case 5:
                    textQuote = "��� ��������� ����. ���� ������ ������, ������ � ���. �� ����";
                    autorName = "�������� ��������";
                    break;
                case 6:
                    textQuote = "����� ����� ��� �� �������, ��� � ��������� ������ �� ����";
                    autorName = "���� �������";
                    break;
                case 7:
                    textQuote = "˳��� ������ �����, �� ���� ������";
                    autorName = "���� ��������";
                    break;
                case 8:
                    textQuote = "��� �� ����, ���� �� �� ������� ������.";
                    autorName = "������� ��������";
                    break;
                case 9:
                    textQuote = "����� ��� �� ��� ��������, ����, ������� �� ����� ����� ����������";
                    autorName = "������ ���������";
                    break;
                case 10:
                    textQuote = "��� �� �� ����� ���� ��������� ����������, ���� �� ����� �������� ������� ��������� ����� �� ������";
                    autorName = "����� �����";
                    break;
                case 11:
                    textQuote = "�� �����, ������, ������, �� ����� ����� �� ���� ������� ����� �� ������";
                    autorName = "\n\t����������� ����";
                    break;
                default:
                    textQuote = "�������";
                    autorName = "������";
                    break;
            }
            return textQuote+autorName;
        }
        //private Quote stringQuote(int num)
        //{
        //    switch (num)
        //    {
        //        case 1:
        //            quote.textQuote = "����� �� �� �� ����������� ���� � ����� ����������� ����";
        //            quote.autorName="˳�� ��������";
        //            break;
        //        case 2:  quote.textQuote = "���� ����� �����������, ����� � ����� ������";
        //            quote.autorName="���� ������"; 
        //            break;
        //        case 3:  quote.textQuote = "�� ��� �� ������ �����, ��� � ������ ���� ������";
        //            quote.autorName="������� ���������"; 
        //            break;
        //        case 4:  quote.textQuote = "� ����� � ��� ���� ����� �����: � �����, ����� � ����� �� ��������, �� ����������� �� ������ \"�\"";
        //            quote.autorName = "������ ���������"; 
        //            break;
        //        case 5:  quote.textQuote = "��� ��������� ����. ���� ������ ������, ������ � ���. �� ����";
        //                 quote.autorName = "�������� ��������"; 
        //            break;       
        //        case 6:  quote.textQuote = "����� ����� ��� �� �������, ��� � ��������� ������ �� ����";
        //                 quote.autorName = "���� �������"; 
        //            break;       
        //        case 7:  quote.textQuote = "˳��� ������ �����, �� ���� ������";
        //                 quote.autorName = "���� ��������"; 
        //            break;       
        //        case 8:  quote.textQuote = "��� �� ����, ���� �� �� ������� ������.";
        //            quote.autorName = "������� ��������"; 
        //            break;       
        //        case 9:  quote.textQuote = "����� ��� �� ��� ��������, ����, ������� �� ����� ����� ����������";
        //            quote.autorName = "������ ���������"; 
        //            break;       
        //        case 10: quote.textQuote = "��� �� �� ����� ���� ��������� ����������, ���� �� ����� �������� ������� ��������� ����� �� ������";
        //            quote.autorName = "����� �����";
        //            break;
        //        case 11: quote.textQuote = "�� �����, ������, ������, �� ����� ����� �� ���� ������� ����� �� ������";
        //            quote.autorName = "\n\t����������� ����"; 
        //            break;
        //        default:quote.textQuote = "�������";
        //            quote.autorName = "������";
        //            break;
        //    }
        //    return quote;
        //}
    }
}
