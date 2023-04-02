Messanger<EmailMessage> messanger = new Messanger<EmailMessage>();


class Car
{

}
interface IMessage
{
    string Text { set; get; }
}

interface IPrintable
{
    void Print();
}

class Message : IMessage, IPrintable
{
    public string Text { get; set; }

    public Message() { }
    public Message(string text)
    {
        Text = text;
    }

    public void Print()
    {
        Console.WriteLine(Text);
    }
}

class EmailMessage : Message
{

}

class SmsMessage : Message
{

}

class Messanger<T> where T : IMessage, IPrintable
{
    public void Send(T message)
    {
        Console.WriteLine(message);
        message.Print();
    }
}

interface IId<T>
{
    T Id { set; get; }
}

class Person<T> : IId<T>
{
    public T Id { get; set; }
}

class PersonIntId : IId<int>
{
    public int Id { get; set; }
}