
import { IconType } from 'react-icons';



const ButtomHome=(props:{name:string,icon:IconType})=>{

    return (    
        <div className="btHome">            
        <props.icon className='iconHome'/>
        <p>{props.name}</p>
        </div>   
    )
}


export default ButtomHome;
