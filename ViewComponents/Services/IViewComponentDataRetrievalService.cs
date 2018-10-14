using System;

namespace ViewComponents.Services
{
    public interface IViewComponentDataRetrievalService<T> where T : class
    {
        T GetData(Guid id);
    }
}
