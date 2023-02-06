
import './App.css';

import TravelsPage from './pages/travels-page';
import HomePage from './pages/home-page';
import { Routes, Route, Link, Outlet } from 'react-router-dom';
import ExcelPage from './pages/excel-page';
import DetailTravelPage from './pages/detail-travel-page';
import DetailPage from './pages/detail-travel-page';




function App() {
 
  return (
    <>
        <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/excel" element={<ExcelPage />} />
        <Route path="/viagens" element={<TravelsPage  />} />   
        <Route path="/viagens/:id"  element={<DetailTravelPage  />} />   
   </Routes>
    </>

  );
}





export default App;
