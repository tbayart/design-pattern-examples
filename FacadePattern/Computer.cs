using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class Computer
    {
        private readonly CPU m_cpu; // only write in constructor
        private readonly HardDriver m_hardDriver; // no posibility to refactor code of subsystem
        private readonly Memory m_memory;
        private const int SectorSize = 10;
        private const long BootAddress = 1;

        public Computer()
        {
            m_cpu = new CPU();
            m_hardDriver = new HardDriver();
            m_memory = new Memory();
        }

        public void Run()
        {
            m_cpu.Freeze();
            m_memory.Load(m_hardDriver.Read(SectorSize));
            m_cpu.Jump(BootAddress);
            m_cpu.Excute();
        }
    }
}
