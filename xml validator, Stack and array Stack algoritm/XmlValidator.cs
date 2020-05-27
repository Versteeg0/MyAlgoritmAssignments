
namespace Alg1.Practica.Practicum5
{
    public class XmlValidator
    {
        public bool Validate(string xml)
        {
            Stack stack = new Stack();

            foreach (char s in xml)
            {
                if (s == '<')
                {
                    xml = "";
                }
                else if (s == '>' && xml.Length > 0)
                {
                    if (xml[0] == '/')
                    {
                        xml = xml.Remove(0, 1);
                        if (xml == stack.Peek())
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        stack.Push(xml);
                    }
                }
                else
                {
                    xml = xml + s;
                }
            }
            if (!stack.IsEmpty())
            {
                return true;
            }
            return true;
        }

    }
}


