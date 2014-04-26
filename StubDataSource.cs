using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities;
using Cain.Domain.Entities.Enums;
using System.Collections;


namespace Cain.Infrastructure.Fakes
{
    public class StubDataSource : IDataSource
    {
        private IList<Event> _events = null;
        private static StubDataSource _instance = null;

        public StubDataSource()
        {
            _events = new List<Event>();
            _events.Add(
                new Event(
                                                Title: "Examn #1",
                                                Description: "First evaluation",
                                                InitialDateTime: new DateTime(2032, 12, 25, 13, 0, 0, DateTimeKind.Local),
                                                FinalDateTime: new DateTime(2032, 12, 25, 15, 0, 0, DateTimeKind.Local),
                                                EnviromentLocation: "Fake location",
                                                Kind: EventKind.Exam
                )
            );
            _events.Add(
             new Event(
                                             Title: "Examn #2",
                                             Description: "Second evaluation",
                                             InitialDateTime: new DateTime(2032, 12, 25, 15, 0, 0, DateTimeKind.Local),
                                             FinalDateTime: new DateTime(2032, 12, 25, 17, 0, 0, DateTimeKind.Local),
                                             EnviromentLocation: "Fake location",
                                             Kind: EventKind.Exam
                 )
            );

            _events.Add(
             new Event(
                                             Title: "Practice #1",
                                             Description: "All students should have solve all problems",
                                             InitialDateTime: new DateTime(2032, 10, 31, 00, 0, 0, DateTimeKind.Local),
                                             FinalDateTime: new DateTime(2032, 11, 5, 00, 0, 0, DateTimeKind.Local),
                                             EnviromentLocation: "Fake location",
                                             Kind: EventKind.Practice
                 )
            );

            _events.Add(
             new Event(
                                             Title: "Practice #2",
                                             Description: "All students should have solve all problems",
                                             InitialDateTime: new DateTime(2032, 12, 21, 00, 0, 0, DateTimeKind.Local),
                                             FinalDateTime: new DateTime(2032, 12, 24, 00, 0, 0, DateTimeKind.Local),
                                             EnviromentLocation: "Fake location",
                                             Kind: EventKind.Practice
                 )
            );
        }

        IEnumerable IDataSource.Events
        {
            get
            {
                return _events;
            }
        }
    }
}
