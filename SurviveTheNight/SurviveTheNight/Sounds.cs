using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SurviveTheNight
{
    public class Sounds
    {
        public void playSoundWeapon()
        {
            SoundPlayer weaponSound = new SoundPlayer(@"C:\Users\stylo\source\repos\SurviveTheNight\SurviveTheNight\Resources\Sounds\gunshot.wav");
            weaponSound.Play();
        }

        public void playSoundDeath()
        {
            SoundPlayer deathSound = new SoundPlayer(@"C:\Users\stylo\source\repos\SurviveTheNight\SurviveTheNight\Resources\Sounds\death.wav");
            deathSound.Play();
        }

        public void playSoundButtonClick()
        {
            SoundPlayer buttonSound = new SoundPlayer(@"C:\Users\stylo\source\repos\SurviveTheNight\SurviveTheNight\Resources\Sounds\click.wav");
            buttonSound.Play();
        }

        public void playSoundTheme()
        {
            SoundPlayer themeSound = new SoundPlayer(@"C:\Users\stylo\source\repos\SurviveTheNight\SurviveTheNight\Resources\Sounds\theme2.wav");
            themeSound.Play();
        }

        public void playSoundAmmoDrop()
        {
            SoundPlayer ammoDropSound = new SoundPlayer(@"C:\Users\stylo\source\repos\SurviveTheNight\SurviveTheNight\Resources\Sounds\ammodrop.wav");
            ammoDropSound.Play();
        }

        public void playSoundAmmoPickUp()
        {
            SoundPlayer ammoPickUpSound = new SoundPlayer(@"C:\Users\stylo\source\repos\SurviveTheNight\SurviveTheNight\Resources\Sounds\ammopickup.wav");
            ammoPickUpSound.Play();
        }

    }
}
