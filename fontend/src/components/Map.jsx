import { useEffect, useState } from 'react';
import { MapContainer, TileLayer, Marker, Popup } from 'react-leaflet';
import axios from 'axios';
import 'leaflet/dist/leaflet.css';
import { useNavigate } from 'react-router-dom';

function Map() {
  const [regions, setRegions] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    const fetchRegions = async () => {
      try {
        const response = await axios.get('http://localhost:5000/api/regions');
        setRegions(response.data);
      } catch (err) {
        console.error('Error fetching regions:', err);
      }
    };
    fetchRegions();
  }, []);

  return (
    <div className="p-4">
      <h2 className="text-2xl font-bold mb-4">Map of Vietnam</h2>
      <MapContainer center={[16.0, 108.0]} zoom={6} style={{ height: '500px', width: '100%' }}>
        <TileLayer
          url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
          attribution='&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
        />
        {regions.map((region) => (
          <Marker key={region.id} position={[region.latitude || 16.0, region.longitude || 108.0]}>
            <Popup>
              <div>
                <h3>{region.regionName}</h3>
                <button
                  onClick={() => navigate(`/region/${region.id}`)}
                  className="bg-blue-500 text-white px-2 py-1 rounded"
                >
                  View Details
                </button>
              </div>
            </Popup>
          </Marker>
        ))}
      </MapContainer>
    </div>
  );
}

export default Map;