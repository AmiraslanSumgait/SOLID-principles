using System;

namespace SOLID_principles
{
    //Single Responsibility******************************************
    //Bad Example---------------------------
    //public class GuitarAmp {

    //    public void VolumeUp()
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public void VolumeDown()
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public void AddSpecialEffects()
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public void OutputToHeadphones()
    //    {
    //        throw new NotImplementedException();
    //    }

    //}
    //Good Example-----------------
    public class VolumeComponent
    {
        public void VolumeUp()
        {
            throw new NotImplementedException();
        }
        public void VolumeDown()
        {
            throw new NotImplementedException();
        }
    }
    public class SpecialEffectsComponent {

        public void AddSpecialEffects()
        {
            throw new NotImplementedException();
        }
    }
    public class HeadphoneComponent
    {
        public void OutputToHeadphones()
        {
            throw new NotImplementedException();
        }
    }
    public class GuitarAmp
    {
        public VolumeComponent VolumeComponent { get; set; }
        public HeadphoneComponent HeadphoneComponent { get; set; }
        public SpecialEffectsComponent SpecialEffectsComponent { get; set; }

        public GuitarAmp(VolumeComponent volumeComponent,HeadphoneComponent headphoneComponent,SpecialEffectsComponent specialEffectsComponent)
        {
            VolumeComponent = volumeComponent;
            HeadphoneComponent = headphoneComponent;
            SpecialEffectsComponent = specialEffectsComponent;
        }
        public void PlayAwesome()
        {
            VolumeComponent.VolumeUp();
            VolumeComponent.VolumeDown();
            HeadphoneComponent.OutputToHeadphones();
            SpecialEffectsComponent.AddSpecialEffects();
        }
    }
    // Single responsibility prinsipi adindan gorunduyu kimi her bir sinif və ya methodun bir işi olmalıdır. Bu sinifdəki hər şey tək bir məqsədlə əlaqəli olmalıdır.
    // Belə desək sinif bir və yalnız bir işi görməlidir.Bad example da yazdigimiz kodda gitara guclendiricisi  bir cox isi volume up,volume down ,special effects kimi bir nece metodu 
    //ozunde cemlesdirir.Buda single responsibility qaydasini pozur.Bu problemin helli ucun Volume up,Volume down her ikisi sesle bagli oldugundan eyni classa, eyni ile AddSpecialEffects,OutputToHeadphones
    //yeni classlar acaraq her bir isi qruplasdiraraq bu qaydani tetbiq etdik
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
