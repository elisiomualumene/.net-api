public abstract class ValueObject<T> {
    protected readonly required T Value;

    public object ToStsring(){
        if(Value == null){
            try {
                _ = Value.ToString();
            } catch (Exception)
            {
                return Value + "";
            }
        }

        return "";
    }

}