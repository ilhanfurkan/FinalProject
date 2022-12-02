
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Core.DataAccess
{
    // Yazılım geliştirme hayatınızda bi kere yazacağınz ve bir daha yazmayacağınız bir yapıdır.
    // generic constraint= generic kısıtlama
    // class: referance type
    // IEntity: T bir referans tip olmalı ve T ya IEntity olabilir ya da IEntity'den implemente olan bir şey olabilir.
    //new(): new'lenebilir olmalıdır.
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filter=null filtre vermeyede bilirsin demektir. tamamının istendiği kısım ama istersek koşul koyupta çağırabiliyoruz.
        T Get(Expression<Func<T, bool>> filter); //bir koşul vererek istenilen yer
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
