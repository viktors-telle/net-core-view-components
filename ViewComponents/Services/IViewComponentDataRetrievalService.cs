namespace ViewComponents.Services
{
    public interface IViewComponentDataRetrievalService<O, I> 
        where O : class         
    {
        O GetData(I input);
    }
}
