class Report
{
    void createReport()
    {
        System.out.println("Report Created");
    }
}

class ReportPrint
{
    void printReport()
    {
        System.out.println("Printing Report");
    }
}

class Main
{
    public static void main(String args[])
    {
        Report r = new Report();

        r.createReport();

        ReportPrint p =
        new ReportPrint();

        p.printReport();
    }
}