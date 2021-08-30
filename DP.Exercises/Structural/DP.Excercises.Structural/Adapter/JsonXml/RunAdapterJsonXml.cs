using System;

namespace DP.Excercises.Structural.Adapter.JsonXml
{
    class RunAdapterJsonXml
    {
        public static void Execute()
        {
            var editorTexto = new EditorTexto();

            editorTexto.AddFile(new SystemJson());
            editorTexto.ShowMessage();

            editorTexto.AddFile(new SystemJsonXmlAdapter( new SystemXml() ));
            editorTexto.ShowMessage();

        }
    }


    internal class SystemJsonXmlAdapter : ITextable
    {
        private readonly SystemXml _systemXmlFile;

        public SystemJsonXmlAdapter(SystemXml systemXmlFile)
        {
            _systemXmlFile = systemXmlFile;
        }

        // Adapter
        public string ExtractTextContent()
        {
            return $"XML content is {_systemXmlFile.ExtractTextContentIncompatible()}";
        }
    }

    internal class SystemXml
    {
        // Adaptee  class
        public int ExtractTextContentIncompatible()
        {
            return 666;
        }
    }


    internal class EditorTexto
    {
        private string _mensaje;

        public void AddFile(ITextable textable)
        {
            _mensaje = textable.ExtractTextContent();
        }

        public void ShowMessage()
        {
            if (!string.IsNullOrEmpty(_mensaje))
                Console.WriteLine($"el contenidod es: {_mensaje}");
        }
    }

    internal interface ITextable
    {
        string ExtractTextContent();
    }


}