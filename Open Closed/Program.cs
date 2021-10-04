using System;

namespace Open_Closed
{
    //Bad Example-----------------------------------------
    //public class Invoice
    //{
    //    public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
    //    {
    //        double finalAmount = 0;
    //        if (invoiceType == InvoiceType.FinalInvoice)
    //        {
    //            finalAmount = amount - 100;
    //        }
    //        else if (invoiceType == InvoiceType.ProposedInvoice)
    //        {
    //            finalAmount = amount - 50;
    //        }
    //        return finalAmount;
    //    }
    //}
    //public enum InvoiceType
    //{
    //    FinalInvoice,
    //    ProposedInvoice
    //};
    //Good Example------------------------------------------
    
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }
    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
    public class RecurringInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
    //Yuxarıdakı koddan gorduyunuz kimi , biz üç class yaratdıq  FinalInvoice ,  ProposedInvoice və  RecurringInvoice .
    //Bu üç sinifin hamısı əsas Invoicedan(Faktura) miras almisdir və istəsələr, GetInvoiceDiscount () metodunu ləğv edə bilərlər  .
    //Sabah başqa bir Faktura Tipinin əlavə edilməsinə ehtiyac varsa, onu Faktura sinifindən miras alaraq yeni bir sinif yaratmalıyıq.
    //Diqqətinizi çəkməyiniz lazım olan nöqtə, Faktura sinifinin kodunu dəyişdirməyimizdir.
    class Program
    {
        static void Main(string[] args)
        {
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine(FInvoiceAmount);
            Console.WriteLine(PInvoiceAmount);
            Console.WriteLine(RInvoiceAmount);
        }
    }
}


