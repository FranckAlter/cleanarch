using exam_sales_reporter_kata.domain;

namespace exam_sales_reporter_kata.Cli;

public static class Parser
{
    public static Commande[] toObject(File file)
    {
        string[] dataContentString = File.ReadAllLines(file);
        var otherLines = dataContentString.Skip(1);
        //
    }
}