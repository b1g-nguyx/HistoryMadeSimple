import { useEffect, useState } from 'react';
import axios from 'axios';

function Blog() {
  const [posts, setPosts] = useState([]);
  const [newPost, setNewPost] = useState({ title: '', content: '' });

  useEffect(() => {
    const fetchPosts = async () => {
      try {
        const response = await axios.get('http://localhost:5000/api/blogposts');
        setPosts(response.data);
      } catch (err) {
        console.error('Error fetching blog posts:', err);
      }
    };
    fetchPosts();
  }, []);

  const handleCreatePost = async (e) => {
    e.preventDefault();
    try {
      const token = localStorage.getItem('token');
      await axios.post('http://localhost:5000/api/blogposts', newPost, {
        headers: { Authorization: `Bearer ${token}` },
      });
      setNewPost({ title: '', content: '' });
      // Refresh posts
      const response = await axios.get('http://localhost:5000/api/blogposts');
      setPosts(response.data);
    } catch (err) {
      console.error('Error creating blog post:', err);
    }
  };

  return (
    <div className="p-4">
      <h2 className="text-2xl font-bold mb-4">Blog</h2>
      <div className="mb-6">
        <h3 className="text-xl font-semibold mb-2">Create a New Post</h3>
        <form onSubmit={handleCreatePost}>
          <div className="mb-4">
            <label className="block text-gray-700">Title</label>
            <input
              type="text"
              value={newPost.title}
              onChange={(e) => setNewPost({ ...newPost, title: e.target.value })}
              className="w-full p-2 border rounded"
              required
            />
          </div>
          <div className="mb-4">
            <label className="block text-gray-700">Content</label>
            <textarea
              value={newPost.content}
              onChange={(e) => setNewPost({ ...newPost, content: e.target.value })}
              className="w-full p-2 border rounded"
              rows="4"
              required
            />
          </div>
          <button type="submit" className="bg-blue-500 text-white p-2 rounded hover:bg-blue-600">
            Create Post
          </button>
        </form>
      </div>
      <div>
        <h3 className="text-xl font-semibold mb-2">Posts</h3>
        {posts.map((post) => (
          <div key={post.id} className="bg-white p-4 rounded shadow-md mb-4">
            <h4 className="text-lg font-bold">{post.title}</h4>
            <p>{post.content}</p>
            <p className="text-gray-500 text-sm">Posted on: {new Date(post.createdDate).toLocaleString()}</p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default Blog;