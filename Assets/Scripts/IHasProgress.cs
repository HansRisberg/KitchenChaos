using System;

public interface IHasProgress {


    public event EventHandler<onProgressChangedEventArgs> OnProgressChanged;
    public class onProgressChangedEventArgs : EventArgs {
        public float progressNormalized;
    }
}
