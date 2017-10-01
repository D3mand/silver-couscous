using Xunit;
using Moq;
using Engine.Actions;
using External.Jacks;
using Engine.Entities;
using System;
using Engine.Boundaries;
using Engine.Interactors;
using Engine.Validator;
using Engine.Boundaries.Requests;

namespace Engine.Tests.UnitTests
{
    public class GigTests
    {
        Mock<GigRepository> _gigRepo;
        Mock<Validator<CreateGigRequestMessage>> _requestGigValidator;
        Mock<Validator<CancelGigRequestMessage>> _cancelGigValidator;

        public GigTests()
        {
            _gigRepo = new Mock<GigRepository>();
            _requestGigValidator = new Mock<Validator<CreateGigRequestMessage>>();
            _cancelGigValidator = new Mock<Validator<CancelGigRequestMessage>>();
        }

        [Fact]
        public void RequestGig()
        {
            // Arrange
            _gigRepo.Setup(x => x.Save(It.IsAny<Gig>()));
            _requestGigValidator.Setup(x => x.Validate(It.IsAny<CreateGigRequestMessage>())).Returns(true);
            var sut = new RequestGig(_gigRepo.Object, _requestGigValidator.Object);

            CreateGigRequestMessage request
                = new CreateGigRequestMessage(1, 
                100, 
                "Move Request", 
                "Want to send goods to PE", 
                "PE", 
                "Pretoria", 
                DateTime.Today);          

            // Act
            sut.Handle(request);

            // Assert
            _requestGigValidator.Verify(validator => validator.Validate(request), Times.Once);
            _gigRepo.Verify(repo => repo.Save(It.IsAny<Gig>()), Times.Once());
        }
        
        [Fact]
        public void CancelGig()
        {
            // Arrange
            _gigRepo.Setup(x => x.Remove(It.IsAny<string>()));
            _cancelGigValidator.Setup(x => x.Validate(It.IsAny<CancelGigRequestMessage>())).Returns(true);
            var sut = new CancelGig(_gigRepo.Object, _cancelGigValidator.Object);

            CancelGigRequestMessage request = new CancelGigRequestMessage(Guid.NewGuid().ToString());

            // Act
            sut.Handle(request);

            // Assert
            _cancelGigValidator.Verify(validator => validator.Validate(request), Times.Once);
            _gigRepo.Verify(repo => repo.Remove(It.IsAny<string>()), Times.Once);
        }       
    }
}
