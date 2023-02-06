


import axios from "axios";
export default class TravelService{
    
     apiUrl = process.env.REACT_APP_WEB_API_URL;
     getTravels=async()=>{    
        return await axios.get(this.apiUrl+"/Viagens");        
    }
    getTravelId=async(id:number)=>{   
        return await axios.get(this.apiUrl+"/Viagens/"+id);
    }
    postTravel=async(data:any)=>{
        await axios.post(this.apiUrl+"/Viagens",data)
    }
    deleteTravel=async(id:number)=>{
        await axios.delete(this.apiUrl+"/Viagens/"+id)
    }
}







