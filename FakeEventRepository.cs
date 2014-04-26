using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Repositories;
using Cain.Domain.Entities;

namespace Cain.Infrastructure.Fakes
{
    public class FakeEventRepository : IEventRepository
    {
        private  IList<Event> _eventsDataSource;

        public FakeEventRepository(IDataSource events)
        {
            _eventsDataSource= events.Events.AsQueryable().OfType<Event>().ToList<Event>();
        }


        IQueryable<Event> IEventRepository.Practices
        {
            get { return _eventsDataSource.AsQueryable<Event>(); }
        }

        public void Create(Event @event)
        {
            _eventsDataSource.Add(@event);
        }

        public void Remove(Event @event)
        {
            _eventsDataSource.Remove(@event);
        }

        public void Update(Event @event)
        {
            var oldEvent = (_eventsDataSource.Where(currentEvent => currentEvent.Equals(@event))).FirstOrDefault();
            oldEvent = @event;
        }

        public Event Find(object Id)
        {
            Event @eventFound = null;
            @eventFound = _eventsDataSource.FirstOrDefault(currentEvent => currentEvent.Id == (int)Id);
            return @eventFound;
        }

        public IQueryable<Event> FindAll()
        {
            return _eventsDataSource.AsQueryable<Event>();
        }

        public IQueryable<Event> FindAllWhere(Func<Event, bool> predicate)
        {
            return _eventsDataSource.Where(predicate).AsQueryable<Event>();
        }

        public IQueryable<Event> FindObjectGraph(Func<Event, bool> predicate, string descendants)
        {
            return _eventsDataSource.Where(predicate).AsQueryable<Event>();
        }

        public int NumberOfEvents()
        {
            return _eventsDataSource.Count;
        }

        public IQueryable<Event> Exams
        {
            get { 
                return 
                _eventsDataSource
                .Where(
                    current => current.Kind == Domain.Entities.Enums.EventKind.Exam )
                .AsQueryable(); 
            }
        }
    }
}
