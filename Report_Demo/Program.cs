namespace Report_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Choice:1.PDF 2.DOCX 3.XML 4.JSON 5.Excel");
                int choice = Convert.ToInt32(Console.ReadLine());

                ReportFactory factory = new ReportFactory();
                Report report = factory.GetSomeReport(choice);
                report.GenerateReport();

                Console.WriteLine("Do you want to continue?(y/n)");
                string ynChoice = Console.ReadLine();

                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }
}

public abstract class Report
{
    protected abstract void Parse();
    protected abstract void Validate();
    protected abstract void Save();
    public virtual void GenerateReport()
    {
        Parse();
        Validate();
        Save();
        Console.WriteLine("Report Generated");
    }
}

public abstract class SpecialReport : Report
{
    protected abstract void ReValidate();
    public override void GenerateReport()
    {
        Parse();
        Validate();
        ReValidate();
        Save();
        Console.WriteLine("Special  Report Generated");
    }
}

public class ReportFactory
{
    public Report GetSomeReport(int choice)
    {
        Report report = null;
        switch (choice)
        {
            case 1:
                report = new PDF();
                break;
            case 2:
                report = new DOCX();
                break;
            case 3:
                report = new XML();
                break;
            case 4:
                report = new JSON();
                break;
            case 5:
                report = new Excel();
                break;
            default:
                report = null;
                break;
        }
        return report;
    }

    public class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("PDF Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("PDF Saved");
        }
    }

    public class DOCX : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("DOCX Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("DOCX Validated");
        }
        
        protected override void Save()
        {
            Console.WriteLine("DOCX Saved");
        }
    }
    public class XML : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("XML Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("XML Validated");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("XML ReValidated");
        }
        protected override void Save()
        {
            Console.WriteLine("XML Saved");
        }
    }
    public class JSON : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("JSON Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("JSON Validated");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("JSON ReValidated");
        }
        protected override void Save()
        {
            Console.WriteLine("JSON Saved");
        }
    }
    public class Excel : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("Excel Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("Excel Validated");
        }
        
        protected override void Save()
        {
            Console.WriteLine("Excel Saved");
        }
    }
}
