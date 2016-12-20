using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Order 的摘要说明
/// </summary>
public class Order
{
    private string id;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private double price;

    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    private int num;

    public int Num
    {
        get { return num; }
        set { num = value; }
    }
    private string pic;

    public string Pic
    {
        get { return pic; }
        set { pic = value; }
    }
    private string type_id;

    public string Type_id
    {
        get { return type_id; }
        set { type_id = value; }
    }

	public Order()
	{
        num = 0;
	}
}