namespace exam_sales_reporter_kata.domain;

public class Commande
{
    private int orderid;
    private string username;
    private int numberItems;
    private double totalBasket;
    private DateTime date;

    public Commande(int o, string u, int n, double t, DateTime d)
    {
        orderid = o;
        username = u;
        numberItems = n;
        totalBasket = t;
        date = d;
    }
}