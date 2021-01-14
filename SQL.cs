using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommissionHub
{
    public class SQL
    {
        public UserModel GetUserInfo(int UserId)
        {
            throw new NotImplementedException();
        }
        
        public bool SaveUserModel(UserModel user)
        {
            throw new NotImplementedException();

        }
        public ArtistModel GetArtist(int artistPageID)
        {
            throw new NotImplementedException();
            return new ArtistModel();
        }
        public void SaveArtist(ArtistModel artistPage)
        {
            throw new NotImplementedException();
        }

        public OpenCommisionsModel GetOpenCommisions(int commisionId)
        {
            throw new NotImplementedException();
            return new OpenCommisionsModel();
        }
        public void SaveCommisions(OpenCommisionsModel commision)
        {
            throw new NotImplementedException();
        }
    }
}
