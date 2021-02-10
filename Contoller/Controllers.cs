using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollABoll
{
    class Controllers : IExecutable, IInitializable, ICleanable
    {
        private List<IExecutable> executables = new List<IExecutable>();
        private List<ICleanable> cleanables = new List<ICleanable>();
        private List<IInitializable> initializables = new List<IInitializable>();


        public Controllers Add(IController controller)
        {
            if (controller is IExecutable executable)
            {
                executables.Add(executable);
            }
            if (controller is ICleanable cleanable)
            {
                cleanables.Add(cleanable);
            }
            if (controller is IInitializable initializable)
            {
                initializables.Add(initializable);
            }
            return this;
        }

        public Controllers Add(List<IController> controller)
        {
            for (int i = 0; i < controller.Count; i++)
            {
                if (controller[i] is IExecutable executable)
                {
                    executables.Add(executable);
                }
                if (controller[i] is ICleanable cleanable)
                {
                    cleanables.Add(cleanable);
                }
                if (controller[i] is IInitializable initializable)
                {
                    initializables.Add(initializable);
                }
                
            }
            return this;
        }

        public void Clean() 
        {
            for (int i = 0; i < cleanables.Count; ++i)
            {
                cleanables[i].Clean();
            }
        }

        public void Execute(float deltaTime)
        {
            for (int i = 0; i < executables.Count; ++i)
            {
                executables[i].Execute(deltaTime);
            }
        }

        public void Initialize()
        {
            for (int i = 0; i < initializables.Count; ++i)
            {
                initializables[i].Initialize();
            }
        }
    }
}
