using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Cain.Domain.Entities;
using Cain.Domain.Entities.Enums;
using Cain.Domain.Repositories;
using Cain.Domain.Shared;
using Cain.Infrastructure.Fakes;


namespace Cain.Infrastructure.UnitTest
{
    [TestClass]
    public class RepositoriesUnitTest
    {
        private IEventRepository _repository = null;
        private IUnitOfWork _unitOfWork = null;
        private IDataSource _fakeDataSource = null;

        [TestInitialize]
        public void Initialize()
        {

            _fakeDataSource = new StubDataSource();
            _repository = new FakeEventRepository(_fakeDataSource);
            _unitOfWork = new FakeUnitOfWork(); 
        }

        [TestMethod]
        public void ShouldCreatedANewEvent()
        {
            // Arrange.
            var @event = new Event(
                                            Title : "Examn #3", 
                                            Description : "Second evaluation",
                                            InitialDateTime : DateTime.Now,
                                            FinalDateTime : DateTime.Now.AddHours(2),
                                            EnviromentLocation : "Fake location",
                                            Kind : EventKind.Exam
            );
            // At the beginning there shuld be 4 events, then..
            // after creating a new event the number of items shuld to be 5.
            
            // Act
            _repository.Create(@event);
            var expected = 5;
            var actual = _repository.NumberOfEvents();
           
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldCheckIfThereIsANewEventInTheRepository()
        {
            var allEvents = _repository.FindAll().ToList<Event>() ;
            var eventToRemove = allEvents.First();
            _repository.Remove(eventToRemove);
            var expected = 3;
            var actual = _repository.NumberOfEvents();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldCheckIfTheFristEventIsOfExamKind()
        {
            var actual = _repository.Find(0).Kind;
            var expected = EventKind.Exam;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShoudlCheckIfFindAllIsWorking()
        {
            var actual = _repository.FindAll().Count();
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGetTwoEventsOfKindPractice()
        {
            var actual = _repository
                                        .FindAllWhere(
                                            current => current.Kind == EventKind.Practice )
                                        .Count();
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}
