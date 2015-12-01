using Pattern;
using Domain.Entities;
using Data.Infrastructure;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System;
using System.Xml.Linq;

namespace Service
{
    public class EventService : Service<Event>, IEventService
    {
        public EventService()
        {
        }
        public void Reserver(int eventId ,int activeMemberId)
        {
            simplemember s = new simplemember();
            Event e = new Event();
            IService<Event> se = new EventService();
            IService<simplemember> ss = new SimpleMemberService();

            s = ss.GetById(activeMemberId);
            
            ICollection<Event> l1 = s.events;
            e = se.GetById(eventId);
            l1.Add(e);
            s.events = l1;
            e.numberOfParticipants++;
            //ss.Update(s);
            Commit();
            se.Update(e);
           
            Commit();
      
         

/*
            e = se.GetById(eventId);
            Commit();
            ICollection<simplemember> l = e.simplemembers ;
            simplemember z = ss.GetById(activeMemberId);
            Commit();
            l.Add(z);
            e.numberOfParticipants++;
            Commit();
  */
    }
        public IEnumerable<Event> GetEventByUser(int idUser)
        {
            Event e = new Event();
            IService<Event> se = new EventService();
            IService<simplemember> ss = new SimpleMemberService();
            simplemember s = ss.GetById(idUser);

            IEnumerable<Event> l = se.GetMany(r => r.simplemembers.Contains(s),null);

            return l ;
        }


        public void sendEmailViaWebApi(string toAdress , string subject)
        {
            SmtpClient smtpClient = new SmtpClient();
            NetworkCredential basicCredential =
                new NetworkCredential("anis.elfehem@esprit.tn", "jdxfv248");
            MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress("anis.elfehem@esprit.tn");

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = basicCredential;
            smtpClient.EnableSsl = true;

            message.From = fromAddress;
            message.Subject = "inscription avec succes a l'evenement  "+ subject;
            //Set IsBodyHtml to true means you can send HTML email.
           // message.IsBodyHtml = true;
            message.Body = "vous etes inscrit a l'evenement  "+subject ;
            message.To.Add(toAdress);

            try
            {
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                //Error, could not send the message
            }
        }
        public List <String> geocode(string adress)
        {
            List<String> l = new List<string>();
            var address = adress;
            var requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false", Uri.EscapeDataString(address));

            var request = WebRequest.Create(requestUri);
            var response = request.GetResponse();
            var xdoc = XDocument.Load(response.GetResponseStream());

            var result = xdoc.Element("GeocodeResponse").Element("result");
            var locationElement = result.Element("geometry").Element("location");
            var lat = locationElement.Element("lat").Value;
            var lng = locationElement.Element("lng").Value;

            l.Add(lat.ToString());
            l.Add(lng.ToString());

            return l;
        }
    }

   public interface IEventService : IService<Event>
    {
        void Reserver(int eventId, int activeMemberId);
        IEnumerable<Event> GetEventByUser(int idUser);
        void sendEmailViaWebApi(string toAdress , string subject);
        List<String> geocode(string adress);
    }
}
