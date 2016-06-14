using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    class container
    {
        private static Container Container;

        public static void CreateInstance()
        {
            Bootstrap();
        }

        private static void Bootstrap()
        {
            Container = new Container();

            Container.RegisterSingle<IClinica, Clinica>();

            Container.Register<Principal>();
        }

        public static Container GetContainer()
        {
            return Container;
        }

    }
}
