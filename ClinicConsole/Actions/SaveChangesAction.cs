using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicLibrary.Context;
using Feonufry.CUI.Actions;

namespace ClinicLibrary.Actions
{
    public class SaveChangesAction : IAction
    {
        private ClinicContext _context;

        public SaveChangesAction(ClinicContext context)
        {
            _context = context;
        }

        public void Perform(ActionExecutionContext context)
        {
            _context.SaveChanges();
            Console.Clear();
            Console.WriteLine("Changes saved\n");
        }

    }
}
