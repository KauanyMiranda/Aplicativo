
using System.Numerics;

public class Contatos
{
    private int _id;
    public string _nome;
    public string _phone;
    public string _email;
    public string _avatar;

    public Contatos(string nome, string phone)
    {
        _phone = phone;
        _nome = nome;
    }

    public void SetId(int id)
    {
        if (id >= 1)
        {
            _id = id;
        }
        else
        {
            throw new Exception("ID inválido");
        }
    }

    public override string ToString()
    {
        return _id+ " "+_nome+" "+" "+_phone+" "+ _email+" "+_avatar;
    }
    public int GetId()
    {
        return _id;
    }

}
