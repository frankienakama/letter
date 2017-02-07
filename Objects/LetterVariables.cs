namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _sender;
    private string _currentLocation;
    private string _desiredLocation;
    private string _souvenir;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

    public string GetCurrentLocation()
    {
      return _currentLocation;
    }

    public void SetCurrentLocation(string newCurrentLocation)
    {
      _currentLocation = newCurrentLocation;
    }

    public string GetDesiredLocation()
    {
      return _desiredLocation;
    }

    public void SetDesiredLocation(string newDesiredLocation)
    {
      _desiredLocation = newDesiredLocation;
    }

    public string GetSouvenir()
    {
      return _souvenir;
    }

    public void SetSouvenir(string newSouvenir)
    {
      _souvenir = newSouvenir;
    }
  }
}
