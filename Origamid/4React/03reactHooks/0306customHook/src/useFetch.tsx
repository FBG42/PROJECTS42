import React from 'react'
import { produtoType } from './App';

export type typesReturnsOfFetch = {
  data: produtoType[] | null,
  error: object | string | null,
  loading: boolean | null,
  request: (url: string, options?: object) => Promise<void> | Promise<Response> | Promise<JSON>
};

const useFetch = () => {
  const [data, setData] = React.useState<null | produtoType[]>(null)
  const [error, setError] = React.useState<object | string | null>(null)
  const [loading, setLoading] = React.useState<boolean | null>(null)

  async function request(url: string, options: object | undefined) {
    let response;
    let json;
    try {
      setError(null)
      setLoading(true)
      response = await fetch(url, options)
      json = await response.json()
      setData(json)
    } catch(erro: unknown) {
      if (erro instanceof Error) {
        setError(erro.message)
      } else {
        setError('Erro desconhecido')
      }
    } finally {
      setLoading(false)
      return {response, json}
    }
  }

  const returnsOfFetch: typesReturnsOfFetch = {
    data: data || null,
    error,
    loading,
    request
  };

  return returnsOfFetch
}

export default useFetch;