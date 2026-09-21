using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Order
{
    private string comp;
    private string[] arrExtra = new string[3];
    private string extra;
    private string money;

    private string date;

	public Order(string comp,string[] arr_office,string extra,string money,string date)
	{
        this.comp = comp;

        this.arrExtra = arr_office;

        this.extra = extra;

        this.money = money;

        this.date = date;
	}

    

    public string MainComputer
    {
        get { return this.comp; }
        set { this.comp  = value; }
    }

   

    public string[] OfficeStuff
    {
        get { return this.arrExtra; }
        set { this.arrExtra = value; }
    }


    public string Extra
    {
        get { return extra; }
        set { extra = value; }
    } 

    public string Money
    {
        get { return money; }
        set { money = value; }
    }

    

    public string Date
    {
        get { return date; }
        set { date = value; }
    }
    
    
    
    
    
    
}
