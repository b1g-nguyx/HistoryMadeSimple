import { useEffect, useState } from 'react';
import axios from 'axios';

function Livestream() {
  const [livestreams, setLivestreams] = useState([]);

  useEffect(() => {
    const fetchLivestreams = async () => {
      try {
        const response = await axios.get('http://localhost:5000/api/media/livestreams');
        setLivestreams(response.data);
      } catch (err) {
        console.error('Error fetching livestreams:', err);
      }
    };
    fetchLivestreams();
  }, []);

  return (
    <div className="p-4">
      <h2 className="text-2xl font-bold mb-4">Livestreams</h2>
      <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
        {livestreams.map((stream) => (
          <div key={stream.id} className="bg-white p-4 rounded shadow-md">
            <video src={stream.filePath} controls className="w-full rounded" />
            <p className="text-gray-500 text-sm mt-2">Uploaded: {new Date(stream.uploadedDate).toLocaleString()}</p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default Livestream;