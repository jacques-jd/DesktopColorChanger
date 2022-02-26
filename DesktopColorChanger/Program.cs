using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopColorChanger
{
    public class Program
    {

        [STAThreadAttribute]
	    public static void Main()
	    {
			AppDomain.CurrentDomain.AssemblyResolve += OnResolveAssembly;
			App.Main();
	    }

        private static System.Reflection.Assembly OnResolveAssembly(object sender, ResolveEventArgs args)
        {
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Reflection.AssemblyName assemblyName = new System.Reflection.AssemblyName(args.Name);

            var path = assemblyName.Name + ".dll";
            if (assemblyName.CultureInfo.Equals(System.Globalization.CultureInfo.InvariantCulture) == false) path = String.Format(@"{0}\{1}", assemblyName.CultureInfo, path);

            using (System.IO.Stream stream = executingAssembly.GetManifestResourceStream(path))
            {
                if (stream == null) return null;

                var assemblyRawBytes = new byte[stream.Length];
                stream.Read(assemblyRawBytes, 0, assemblyRawBytes.Length);
                return System.Reflection.Assembly.Load(assemblyRawBytes);
            }
        }
    }
}
