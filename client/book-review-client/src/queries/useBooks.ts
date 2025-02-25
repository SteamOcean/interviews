import { useQuery } from '@tanstack/react-query'
export function useBooks() {
  return useQuery({ queryKey: ['books'], queryFn: async () => {
    const res = await fetch(`/api/Books`,{headers: {
      'Accept': 'application/json'
    }})
    return res.json()
  }})
}
