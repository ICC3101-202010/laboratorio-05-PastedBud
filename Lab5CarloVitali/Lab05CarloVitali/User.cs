using System;
namespace Lab05CarloVitali
{
    public class User
    {
        // 1- Define a Delegate
        public delegate void EmailVerifiedEventHandler(object source, EventArgs args);

        // 2- Define an Event based on that Delegate
        public event EmailVerifiedEventHandler EmailVerified;

        // 3- Raie the Event
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, EventArgs.Empty);
            }
        }
        public void OnEmailSent(object source, EventArgs e)
        {
            Console.WriteLine("Quiere Verificar su Correo?  ( 1 = Si / 2 = No )");
            int verificacion = Convert.ToInt16(Console.ReadLine());
            if (verificacion == 1)
            {
                OnEmailVerified();
             
            }
        }
    }
}
